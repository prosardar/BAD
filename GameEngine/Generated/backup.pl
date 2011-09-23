<<<<<<< HEAD
:- dynamic( vLine/2 ).
:- dynamic( hLine/2 ).

availableIndexs([7,2,5,6,3,4,1]).
availablePositions([4,2,6,1,5,3]).

%
% prolog's predicates
%

includeIndex(Index):- availableIndexs(Inds), belong(Index, Inds).
includePosition(Position):- availablePositions(Pos), belong(Position,Pos).
includeIndPos(Index, Position):- includeIndex(Index), includePosition(Position).

belong(X, []):- fail,!.
belong(X, [X|L]).
belong(X, [H|L]):- belong(X, L).

goCl(Index, Position, v):- freeCloseLine(Index, Position, v), assert(vLine(Index, Position)), !. 
goCl(Index, Position, h):- freeCloseLine(Index, Position, h), assert(hLine(Index, Position)), !. 
go(Index, Position, v):- freeLine(Index, Position, v), assert(vLine(Index, Position)), !. 
go(Index, Position, h):- freeLine(Index, Position, h), assert(hLine(Index, Position)), !. 

square(Index, Position):- includeIndPos(Index, Position),
	vLine(Index, Position), Ind is Index + 1, vLine(Ind, Position),
	hLine(Position, Index), Pos is Position + 1, hLine(Pos, Index).

square(Index):- square(Ind, Pos), Index is Pos + 6 * Ind - 6. 

freeLine(Index, Position, v):- includePosition(Index), includePosition(Position), not(vLine(Index, Position)).
freeLine(Index, Position, h):- includeIndPos(Index, Position), not(hLine(Index, Position)).

closeLine(Index, Position, v):- Ind is Index - 1, vLine(Ind, Position),
	Pos is Position + 1, hLine(Pos, Ind), hLine(Position, Ind).
closeLine(Index, Position, v):- Ind is Index + 1, vLine(Ind, Position), 
	Pos is Position + 1, hLine(Pos, Index), hLine(Position, Index).
 
closeLine(Index, Position, h):- Ind is Index - 1, hLine(Ind, Position), 
	vLine(Position, Ind), Pos is Position + 1, vLine(Pos, Ind).
closeLine(Index, Position, h):- Ind is Index + 1, hLine(Ind, Position), 
	vLine(Position, Index), Pos is Position + 1, vLine(Pos, Index).

freeCloseLine(Index, Position, v):- freeLine(Index, Position, v), closeLine(Index, Position, v).
=======
:- dynamic( vLine/2 ).
:- dynamic( hLine/2 ).

availableIndexs([7,2,5,6,3,4,1]).
availablePositions([4,2,6,1,5,3]).

%
% prolog's predicates
%

includeIndex(Index):- availableIndexs(Inds), belong(Index, Inds).
includePosition(Position):- availablePositions(Pos), belong(Position,Pos).
includeIndPos(Index, Position):- includeIndex(Index), includePosition(Position).

belong(X, []):- fail,!.
belong(X, [X|L]).
belong(X, [H|L]):- belong(X, L).

goCl(Index, Position, v):- freeCloseLine(Index, Position, v), assert(vLine(Index, Position)), !. 
goCl(Index, Position, h):- freeCloseLine(Index, Position, h), assert(hLine(Index, Position)), !. 
go(Index, Position, v):- freeLine(Index, Position, v), assert(vLine(Index, Position)), !. 
go(Index, Position, h):- freeLine(Index, Position, h), assert(hLine(Index, Position)), !. 

square(Index, Position):- includeIndPos(Index, Position),
	vLine(Index, Position), Ind is Index + 1, vLine(Ind, Position),
	hLine(Position, Index), Pos is Position + 1, hLine(Pos, Index).

square(Index):- square(Ind, Pos), Index is Pos + 6 * Ind - 6. 

freeLine(Index, Position, v):- includePosition(Index), includePosition(Position), not(vLine(Index, Position)).
freeLine(Index, Position, h):- includeIndPos(Index, Position), not(hLine(Index, Position)).

closeLine(Index, Position, v):- Ind is Index - 1, vLine(Ind, Position),
	Pos is Position + 1, hLine(Pos, Ind), hLine(Position, Ind).
closeLine(Index, Position, v):- Ind is Index + 1, vLine(Ind, Position), 
	Pos is Position + 1, hLine(Pos, Index), hLine(Position, Index).
 
closeLine(Index, Position, h):- Ind is Index - 1, hLine(Ind, Position), 
	vLine(Position, Ind), Pos is Position + 1, vLine(Pos, Ind).
closeLine(Index, Position, h):- Ind is Index + 1, hLine(Ind, Position), 
	vLine(Position, Index), Pos is Position + 1, vLine(Pos, Index).

freeCloseLine(Index, Position, v):- freeLine(Index, Position, v), closeLine(Index, Position, v).
>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
freeCloseLine(Index, Position, h):- freeLine(Index, Position, h), closeLine(Index, Position, h).