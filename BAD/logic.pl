%
% Main Logic
%

%:- module(logic, [win/1]). 

:- dynamic vLine(1,1), hLine(1,1).
:- dynamic square(1, 1).

%
% const clauses
%

availableIndexs([1,2,3,4,5,6,7]).
availablePositions([1,2,3,4,5,6]).

%
% prolog's predicates
%

includeIndex(Index):- availableIndexs(Inds), belong(Index, Inds).
includePosition(Position):- availablePositions(Pos), belong(Position,Pos).
includeIndPos(Index, Position):- includeIndex(Index), includePosition(Position).
randIndPos(Index, Position):- Index is random(7), Position is random(6).

belong(X, []):- fail,!.
belong(X, [X|L]).
belong(X, [H|L]):- belong(X, L).

%
% logic
%

go(Index, Position, cpu):- freeCloseLine(Index, Position, v), assert(vLine(Index, Position)), !. 
go(Index, Position, cpu):- freeCloseLine(Index, Position, h), assert(hLine(Index, Position)), !. 

square(Index, Position):- randIndPos(Index, Position),
	vLine(Index, Position), Ind is Index + 1, vLine(Ind, Position),
	hLine(Position, Index), Pos is Position + 1, hLine(Pos, Index).

square(Index):- square(Ind, Pos), Index is Pos + 6 * Ind - 6.  

freeLine(Index, Position, v):- randIndPos(Index, Position), not(vLine(Index, Position)).
freeLine(Index, Position, h):- randIndPos(Index, Position), not(hLine(Index, Position)).

% if it's close return true
closeLine(Index, Position, v):- randIndPos(Index, Position), Ind is Index - 1, vLine(Ind, Position),
	Pos is Position + 1, hLine(Pos, Ind), hLine(Position, Ind).
closeLine(Index, Position, v):- randIndPos(Index, Position), Ind is Index + 1, vLine(Ind, Position), 
	Pos is Position + 1, hLine(Pos, Index), hLine(Position, Index).
 
closeLine(Index, Position, h):- randIndPos(Index, Position), Ind is Index - 1, hLine(Ind, Position), 
	vLine(Position, Ind), Pos is Position + 1, vLine(Pos, Ind).
closeLine(Index, Position, h):- randIndPos(Index, Position), Ind is Index + 1, hLine(Ind, Position), 
	vLine(Position, Index), Pos is Position + 1, vLine(Pos, Index).

freeCloseLine(Index, Position, v):- freeLine(Index, Position, v), closeLine(Index, Position, v).
freeCloseLine(Index, Position, h):- freeLine(Index, Position, h), closeLine(Index, Position, h).


