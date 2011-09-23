:- dynamic( line/3 ).
:- dynamic( availableIndexs/1 ).
:- dynamic( availablePositions/1 ).
:- dynamic( namedSquare/3 ).

%
% prolog's predicates
%

includeIndex(Index):- availableIndexs(Inds), belong(Index, Inds).
includePosition(Position):- availablePositions(Pos), belong(Position,Pos).
includeIndPos(Index, Position):- includeIndex(Index), includePosition(Position).

belong(X, []):- fail,!.
belong(X, [X|L]).
belong(X, [H|L]):- belong(X, L).

deldb():- retractall(availableIndexs(X)), retractall(availablePositions(Y)).

<<<<<<< HEAD
checkNextFree(Index, Position, Dir):- freeCloseLine(I,P,D,O), retract(line(Index, Position, Dir)), !, fail.
checkNextFree(Index, Position, Dir):- not(freeCloseLine(I,P,D,O)). 

team(yellow).
team(red).

go_smart(Index, Position, 0, yellow, Ori):- freeCloseLine(Index, Position, 0, Ori), assert(line(Index, Position, 0)), !. 
go_smart(Index, Position, 1, yellow, Ori):- freeCloseLine(Index, Position, 1, Ori), assert(line(Index, Position, 1)), !. 

go_smart(Index, Position, Dir, non, non):- availableIndexs([F|H]), (F mod 2 =:= 0 -> Dir is 0; Dir is 1),
	freeLine(Index, Position, Dir),	
	assert(line(Index, Position, Dir)),
	checkNextFree(Index, Position, Dir),
	%not(freeCloseLine(I,P,D,O)),
	!. 

go_smart(Index, Position, Dir, non, non):- availableIndexs([F|H]), (F mod 2 =:= 0 -> Dir is 1; Dir is 0),
	freeLine(Index, Position, Dir),	
	assert(line(Index, Position, Dir)),
	checkNextFree(Index, Position, Dir),
	%not(freeCloseLine(I,P,D,O)),
	!. 

go_smart(Index, Position, Dir, non, non):- availableIndexs([F|H]), (F mod 2 =:= 0 -> Dir is 0; Dir is 1),
	freeLine(Index, Position, Dir),	
	assert(line(Index, Position, Dir)),	!. 

go_smart(Index, Position, Dir, non, non):- availableIndexs([F|H]), (F mod 2 =:= 0 -> Dir is 1; Dir is 0),
	freeLine(Index, Position, Dir),	
	minmax(),
	assert(line(Index, Position, Dir)),	!. 

minmax().

%go_smart(Index, Position, 1, non, non):- freeLine(Index, Position, 1), assert(line(Index, Position, 1)), !. 
%go_smart(Index, Position, 0, non, non):- freeLine(Index, Position, 0), assert(line(Index, Position, 0)), !.

=======
team(yellow).
team(red).

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
go(Index, Position, 0, yellow, Ori):- freeCloseLine(Index, Position, 0, Ori), assert(line(Index, Position, 0)), !. 
go(Index, Position, 1, yellow, Ori):- freeCloseLine(Index, Position, 1, Ori), assert(line(Index, Position, 1)), !. 

go(Index, Position, Dir, non, non):- availableIndexs([F|H]), (F mod 2 =:= 0 -> Dir is 0; Dir is 1),
	freeLine(Index, Position, Dir), assert(line(Index, Position, Dir)), !. 
go(Index, Position, 1, non, non):- freeLine(Index, Position, 1), assert(line(Index, Position, 1)), !. 
go(Index, Position, 0, non, non):- freeLine(Index, Position, 0), assert(line(Index, Position, 0)), !. 

square(Index, Position):- includeIndPos(Index, Position),
	line(Index, Position, 0), Ind is Index + 1, line(Ind, Position, 0),
	line(Position, Index, 1), Pos is Position + 1, line(Pos, Index, 1).

square(Index):- square(Ind, Pos), Index is Pos + 6 * Ind - 6.

freeLine(Index, Position, 0):- includeIndPos(Index, Position), not(line(Index, Position, 0)).
freeLine(Index, Position, 1):- includeIndPos(Index, Position), not(line(Index, Position, 1)).

closeLine(Index, Position, 1, updown):- Ind is Index - 1, line(Ind, Position, 1),
	Pos is Position + 1, line(Pos, Ind, 0), line(Position, Ind, 0), closeLine(Index, Position, 1, down).
closeLine(Index, Position, 1, up):- Ind is Index - 1, line(Ind, Position, 1),
	Pos is Position + 1, line(Pos, Ind, 0), line(Position, Ind, 0).
closeLine(Index, Position, 1, downup):- Ind is Index + 1, line(Ind, Position, 1), 
	Pos is Position + 1, line(Pos, Index, 0), line(Position, Index, 0), closeLine(Index, Position, 1, up).
closeLine(Index, Position, 1, down):- Ind is Index + 1, line(Ind, Position, 1), 
	Pos is Position + 1, line(Pos, Index, 0), line(Position, Index, 0).

closeLine(Index, Position, 0, leftright):- Ind is Index - 1, line(Ind, Position, 0), 
	line(Position, Ind, 1), Pos is Position + 1, line(Pos, Ind, 1), closeLine(Index, Position, 0, right). 
closeLine(Index, Position, 0, left):- Ind is Index - 1, line(Ind, Position, 0), 
	line(Position, Ind, 1), Pos is Position + 1, line(Pos, Ind, 1).
closeLine(Index, Position, 0, rightleft):- Ind is Index + 1, line(Ind, Position, 0), 
	line(Position, Index, 1), Pos is Position + 1, line(Pos, Index, 1), closeLine(Index, Position, 0, left).
closeLine(Index, Position, 0, right):- Ind is Index + 1, line(Ind, Position, 0), 
	line(Position, Index, 1), Pos is Position + 1, line(Pos, Index, 1).

freeCloseLine(Index, Position, 0, Ori):- freeLine(Index, Position, 0), closeLine(Index, Position, 0, Ori).
freeCloseLine(Index, Position, 1, Ori):- freeLine(Index, Position, 1), closeLine(Index, Position, 1, Ori).