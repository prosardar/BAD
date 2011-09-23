<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Go_5.cs
 * @procedure go/5 in logic.pl
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

public class Go_5 : Predicate {
    static internal readonly Predicate Go_5_1 = new Predicates.Go_5_1();
    static internal readonly Predicate Go_5_2 = new Predicates.Go_5_2();
    static internal readonly Predicate Go_5_3 = new Predicates.Go_5_3();
    static internal readonly Predicate Go_5_4 = new Predicates.Go_5_4();
    static internal readonly Predicate Go_5_5 = new Predicates.Go_5_5();
    static internal readonly Predicate Go_5_sub_1 = new Predicates.Go_5_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5;

    public Go_5(Term a1, Term a2, Term a3, Term a4, Term a5, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        this.cont = cont;
    }

    public Go_5(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Go_5_1, Go_5_sub_1);
    }

    public override int arity() { return 5; }

    public override string ToString() {
        return "go(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ")";
    }
}

sealed class Go_5_sub_1 : Go_5 {
    static internal readonly Predicate Go_5_sub_2 = new Predicates.Go_5_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_2, Go_5_sub_2);
    }
}

sealed class Go_5_sub_2 : Go_5 {
    static internal readonly Predicate Go_5_sub_3 = new Predicates.Go_5_sub_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_3, Go_5_sub_3);
    }
}

sealed class Go_5_sub_3 : Go_5 {
    static internal readonly Predicate Go_5_sub_4 = new Predicates.Go_5_sub_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_4, Go_5_sub_4);
    }
}

sealed class Go_5_sub_4 : Go_5 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Go_5_5);
    }
}

sealed class Go_5_1 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yellow");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Close_Line_4(a1, a2, s1, a5, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_2 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yellow");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Close_Line_4(a1, a2, s1, a5, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_3 : Go_5 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f2 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        a8 = engine.makeVariable();
        a7 = new ListTerm(a8, engine.makeVariable());
        Term[] h3 = {a1, a2, a3};
        a9 = new StructureTerm(f2, h3);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a9, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, a3, p2);
        p4 = new Predicates.dollar_dummyLogic__5_2(a3, a8, p3);
        p5 = new Predicates.Available_Indexs_1(a7, p4);
        return new Predicates.dollar_getLevel_1(a6, p5);
    }
}

sealed class Go_5_4 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, s1, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_5 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, s1, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Go_5.cs
 * @procedure go/5 in logic.pl
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

public class Go_5 : Predicate {
    static internal readonly Predicate Go_5_1 = new Predicates.Go_5_1();
    static internal readonly Predicate Go_5_2 = new Predicates.Go_5_2();
    static internal readonly Predicate Go_5_3 = new Predicates.Go_5_3();
    static internal readonly Predicate Go_5_4 = new Predicates.Go_5_4();
    static internal readonly Predicate Go_5_5 = new Predicates.Go_5_5();
    static internal readonly Predicate Go_5_sub_1 = new Predicates.Go_5_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5;

    public Go_5(Term a1, Term a2, Term a3, Term a4, Term a5, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        this.cont = cont;
    }

    public Go_5(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Go_5_1, Go_5_sub_1);
    }

    public override int arity() { return 5; }

    public override string ToString() {
        return "go(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ")";
    }
}

sealed class Go_5_sub_1 : Go_5 {
    static internal readonly Predicate Go_5_sub_2 = new Predicates.Go_5_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_2, Go_5_sub_2);
    }
}

sealed class Go_5_sub_2 : Go_5 {
    static internal readonly Predicate Go_5_sub_3 = new Predicates.Go_5_sub_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_3, Go_5_sub_3);
    }
}

sealed class Go_5_sub_3 : Go_5 {
    static internal readonly Predicate Go_5_sub_4 = new Predicates.Go_5_sub_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Go_5_4, Go_5_sub_4);
    }
}

sealed class Go_5_sub_4 : Go_5 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Go_5_5);
    }
}

sealed class Go_5_1 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yellow");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Close_Line_4(a1, a2, s1, a5, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_2 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("yellow");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Close_Line_4(a1, a2, s1, a5, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_3 : Go_5 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f2 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s1.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        a8 = engine.makeVariable();
        a7 = new ListTerm(a8, engine.makeVariable());
        Term[] h3 = {a1, a2, a3};
        a9 = new StructureTerm(f2, h3);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a9, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, a3, p2);
        p4 = new Predicates.dollar_dummyLogic__0_2(a3, a8, p3);
        p5 = new Predicates.Available_Indexs_1(a7, p4);
        return new Predicates.dollar_getLevel_1(a6, p5);
    }
}

sealed class Go_5_4 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, s1, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}

sealed class Go_5_5 : Go_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("non");
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("line", 3);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a5, engine.trail) ) return engine.fail();
        a6 = engine.makeVariable();
        Term[] h4 = {a1, a2, s1};
        a7 = new StructureTerm(f3, h4);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Assert_1(a7, p1);
        p3 = new Predicates.Free_Line_3(a1, a2, s1, p2);
        return new Predicates.dollar_getLevel_1(a6, p3);
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
