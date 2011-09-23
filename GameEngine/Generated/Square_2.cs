<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Square_2.cs
 * @procedure square/2 in logic.pl
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

public class Square_2 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly IntegerTerm s2 = new IntegerTerm(1);

    public Term arg1, arg2;

    public Square_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Square_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4;
        Predicate p1, p2, p3, p4, p5, p6;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        p1 = new Predicates.Line_3(a4, a1, s2, cont);
        p2 = new Predicates.dollar_plus_3(a2, s2, a4, p1);
        p3 = new Predicates.Line_3(a2, a1, s2, p2);
        p4 = new Predicates.Line_3(a3, a2, s1, p3);
        p5 = new Predicates.dollar_plus_3(a1, s2, a3, p4);
        p6 = new Predicates.Line_3(a1, a2, s1, p5);
        return new Predicates.Include_Ind_Pos_2(a1, a2, p6);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "square(" + arg1 + ", " + arg2 + ")";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Square_2.cs
 * @procedure square/2 in logic.pl
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

public class Square_2 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly IntegerTerm s2 = new IntegerTerm(1);

    public Term arg1, arg2;

    public Square_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Square_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4;
        Predicate p1, p2, p3, p4, p5, p6;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        p1 = new Predicates.Line_3(a4, a1, s2, cont);
        p2 = new Predicates.dollar_plus_3(a2, s2, a4, p1);
        p3 = new Predicates.Line_3(a2, a1, s2, p2);
        p4 = new Predicates.Line_3(a3, a2, s1, p3);
        p5 = new Predicates.dollar_plus_3(a1, s2, a3, p4);
        p6 = new Predicates.Line_3(a1, a2, s1, p5);
        return new Predicates.Include_Ind_Pos_2(a1, a2, p6);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "square(" + arg1 + ", " + arg2 + ")";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
