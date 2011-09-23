/*
 * *** Please do not edit ! ***
 * @(#) Check_Next_Free_3.cs
 * @procedure checkNextFree/3 in logic.pl
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

public class Check_Next_Free_3 : Predicate {
    static internal readonly Predicate Check_Next_Free_3_1 = new Predicates.Check_Next_Free_3_1();
    static internal readonly Predicate Check_Next_Free_3_2 = new Predicates.Check_Next_Free_3_2();
    static internal readonly Predicate Check_Next_Free_3_sub_1 = new Predicates.Check_Next_Free_3_sub_1();

    public Term arg1, arg2, arg3;

    public Check_Next_Free_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Check_Next_Free_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Check_Next_Free_3_1, Check_Next_Free_3_sub_1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "checkNextFree(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class Check_Next_Free_3_sub_1 : Check_Next_Free_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Check_Next_Free_3_2);
    }
}

sealed class Check_Next_Free_3_1 : Check_Next_Free_3 {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        a4 = engine.makeVariable();
        Term[] h2 = {a1, a2, a3};
        a5 = new StructureTerm(f1, h2);
        p1 = new Predicates.dollar_fail_0(cont);
        p2 = new Predicates.dollar_cut_1(a4, p1);
        p3 = new Predicates.Retract_1(a5, p2);
        p4 = new Predicates.Free_Close_Line_4(engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), p3);
        return new Predicates.dollar_getLevel_1(a4, p4);
    }
}

sealed class Check_Next_Free_3_2 : Check_Next_Free_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_dummyLogic__0_4(engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), cont);
    }
}
}

