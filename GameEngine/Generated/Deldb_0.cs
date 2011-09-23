<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Deldb_0.cs
 * @procedure deldb/0 in logic.pl
 */

/*
 * @version P# 1.1.3, on Sept 1 2003;  Prolog Cafe 0.44, on November 12 1999
 * @author Mutsunori Banbara (banbara@pascal.seg.kobe-u.ac.jp)
 * @author Naoyuki Tamura    (tamura@kobe-u.ac.jp)
 * Modified by Jonathan Cook (jjc@dcs.ed.ac.uk)
 */
namespace JJC.Psharp.Predicates {

using JJC.Psharp.Lang;
using JJC.Psharp.Lang.Resource;
using Predicates = JJC.Psharp.Predicates;
using Resources = JJC.Psharp.Resources;

public class Deldb_0 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("availableIndexs", 1);
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("availablePositions", 1);

    public Deldb_0(Predicate cont) {
        this.cont = cont;
    }

    public Deldb_0(){}
    public override void setArgument(Term[] args, Predicate cont) {
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;

        Term[] h2 = {engine.makeVariable()};
        a1 = new StructureTerm(f1, h2);
        Term[] h4 = {engine.makeVariable()};
        a2 = new StructureTerm(f3, h4);
        p1 = new Predicates.Retractall_1(a2, cont);
        return new Predicates.Retractall_1(a1, p1);
    }

    public override int arity() { return 0; }

    public override string ToString() {
        return "deldb";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Deldb_0.cs
 * @procedure deldb/0 in logic.pl
 */

/*
 * @version P# 1.1.3, on Sept 1 2003;  Prolog Cafe 0.44, on November 12 1999
 * @author Mutsunori Banbara (banbara@pascal.seg.kobe-u.ac.jp)
 * @author Naoyuki Tamura    (tamura@kobe-u.ac.jp)
 * Modified by Jonathan Cook (jjc@dcs.ed.ac.uk)
 */
namespace JJC.Psharp.Predicates {

using JJC.Psharp.Lang;
using JJC.Psharp.Lang.Resource;
using Predicates = JJC.Psharp.Predicates;
using Resources = JJC.Psharp.Resources;

public class Deldb_0 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("availableIndexs", 1);
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("availablePositions", 1);

    public Deldb_0(Predicate cont) {
        this.cont = cont;
    }

    public Deldb_0(){}
    public override void setArgument(Term[] args, Predicate cont) {
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;

        Term[] h2 = {engine.makeVariable()};
        a1 = new StructureTerm(f1, h2);
        Term[] h4 = {engine.makeVariable()};
        a2 = new StructureTerm(f3, h4);
        p1 = new Predicates.Retractall_1(a2, cont);
        return new Predicates.Retractall_1(a1, p1);
    }

    public override int arity() { return 0; }

    public override string ToString() {
        return "deldb";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
