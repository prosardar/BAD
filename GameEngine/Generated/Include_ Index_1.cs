<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Include_Index_1.cs
 * @procedure includeIndex/1 in logic.pl
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

public class Include_Index_1 : Predicate {

    public Term arg1;

    public Include_Index_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Include_Index_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        p1 = new Predicates.Belong_2(a1, a2, cont);
        return new Predicates.Available_Indexs_1(a2, p1);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "includeIndex(" + arg1 + ")";
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Include_Index_1.cs
 * @procedure includeIndex/1 in logic.pl
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

public class Include_Index_1 : Predicate {

    public Term arg1;

    public Include_Index_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Include_Index_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        p1 = new Predicates.Belong_2(a1, a2, cont);
        return new Predicates.Available_Indexs_1(a2, p1);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "includeIndex(" + arg1 + ")";
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
