<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Include_Ind_Pos_2.cs
 * @procedure includeIndPos/2 in logic.pl
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

public class Include_Ind_Pos_2 : Predicate {

    public Term arg1, arg2;

    public Include_Ind_Pos_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Include_Ind_Pos_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        p1 = new Predicates.Include_Position_1(a2, cont);
        return new Predicates.Include_Index_1(a1, p1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "includeIndPos(" + arg1 + ", " + arg2 + ")";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Include_Ind_Pos_2.cs
 * @procedure includeIndPos/2 in logic.pl
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

public class Include_Ind_Pos_2 : Predicate {

    public Term arg1, arg2;

    public Include_Ind_Pos_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Include_Ind_Pos_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        p1 = new Predicates.Include_Position_1(a2, cont);
        return new Predicates.Include_Index_1(a1, p1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "includeIndPos(" + arg1 + ", " + arg2 + ")";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
