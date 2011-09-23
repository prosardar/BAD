<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Square_1.cs
 * @procedure square/1 in logic.pl
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

public class Square_1 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(6);

    public Term arg1;

    public Square_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Square_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_minus_3(a5, s1, a1, cont);
        p2 = new Predicates.dollar_plus_3(a3, a4, a5, p1);
        p3 = new Predicates.dollar_multi_3(s1, a2, a4, p2);
        return new Predicates.Square_2(a2, a3, p3);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "square(" + arg1 + ")";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Square_1.cs
 * @procedure square/1 in logic.pl
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

public class Square_1 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(6);

    public Term arg1;

    public Square_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Square_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_minus_3(a5, s1, a1, cont);
        p2 = new Predicates.dollar_plus_3(a3, a4, a5, p1);
        p3 = new Predicates.dollar_multi_3(s1, a2, a4, p2);
        return new Predicates.Square_2(a2, a3, p3);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "square(" + arg1 + ")";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
