<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Named_Square_3.cs
 * @procedure namedSquare/3 in logic.pl
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

public class Named_Square_3 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("namedSquare", 3);

    public Term arg1, arg2, arg3;

    public Named_Square_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Named_Square_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();

        Term[] h2 = {a1, a2, a3};
        a4 = new StructureTerm(f1, h2);
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_call_1(a5, cont);
        return new Predicates.Clause_2(a4, a5, p1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "namedSquare(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Named_Square_3.cs
 * @procedure namedSquare/3 in logic.pl
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

public class Named_Square_3 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("namedSquare", 3);

    public Term arg1, arg2, arg3;

    public Named_Square_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Named_Square_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();

        Term[] h2 = {a1, a2, a3};
        a4 = new StructureTerm(f1, h2);
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_call_1(a5, cont);
        return new Predicates.Clause_2(a4, a5, p1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "namedSquare(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
