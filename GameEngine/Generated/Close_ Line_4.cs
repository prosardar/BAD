<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Close_Line_4.cs
 * @procedure closeLine/4 in logic.pl
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

public class Close_Line_4 : Predicate {
    static internal readonly Predicate Close_Line_4_1 = new Predicates.Close_Line_4_1();
    static internal readonly Predicate Close_Line_4_2 = new Predicates.Close_Line_4_2();
    static internal readonly Predicate Close_Line_4_3 = new Predicates.Close_Line_4_3();
    static internal readonly Predicate Close_Line_4_4 = new Predicates.Close_Line_4_4();
    static internal readonly Predicate Close_Line_4_5 = new Predicates.Close_Line_4_5();
    static internal readonly Predicate Close_Line_4_6 = new Predicates.Close_Line_4_6();
    static internal readonly Predicate Close_Line_4_7 = new Predicates.Close_Line_4_7();
    static internal readonly Predicate Close_Line_4_8 = new Predicates.Close_Line_4_8();
    static internal readonly Predicate Close_Line_4_sub_1 = new Predicates.Close_Line_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public Close_Line_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Close_Line_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Close_Line_4_1, Close_Line_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "closeLine(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class Close_Line_4_sub_1 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_2 = new Predicates.Close_Line_4_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_2, Close_Line_4_sub_2);
    }
}

sealed class Close_Line_4_sub_2 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_3 = new Predicates.Close_Line_4_sub_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_3, Close_Line_4_sub_3);
    }
}

sealed class Close_Line_4_sub_3 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_4 = new Predicates.Close_Line_4_sub_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_4, Close_Line_4_sub_4);
    }
}

sealed class Close_Line_4_sub_4 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_5 = new Predicates.Close_Line_4_sub_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_5, Close_Line_4_sub_5);
    }
}

sealed class Close_Line_4_sub_5 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_6 = new Predicates.Close_Line_4_sub_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_6, Close_Line_4_sub_6);
    }
}

sealed class Close_Line_4_sub_6 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_7 = new Predicates.Close_Line_4_sub_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_7, Close_Line_4_sub_7);
    }
}

sealed class Close_Line_4_sub_7 : Close_Line_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Close_Line_4_8);
    }
}

sealed class Close_Line_4_1 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("updown");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("down");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a2, a5, s3, p1);
        p3 = new Predicates.Line_3(a6, a5, s3, p2);
        p4 = new Predicates.dollar_plus_3(a2, s1, a6, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_minus_3(a1, s1, a5, p5);
    }
}

sealed class Close_Line_4_2 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("up");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a2, a5, s3, cont);
        p2 = new Predicates.Line_3(a6, a5, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s1, a6, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_minus_3(a1, s1, a5, p4);
    }
}

sealed class Close_Line_4_3 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("downup");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("up");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a2, a1, s3, p1);
        p3 = new Predicates.Line_3(a6, a1, s3, p2);
        p4 = new Predicates.dollar_plus_3(a2, s1, a6, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_plus_3(a1, s1, a5, p5);
    }
}

sealed class Close_Line_4_4 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("down");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a2, a1, s3, cont);
        p2 = new Predicates.Line_3(a6, a1, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s1, a6, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_plus_3(a1, s1, a5, p4);
    }
}

sealed class Close_Line_4_5 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("leftright");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("right");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a6, a5, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s3, a6, p2);
        p4 = new Predicates.Line_3(a2, a5, s3, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_minus_3(a1, s3, a5, p5);
    }
}

sealed class Close_Line_4_6 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("left");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a6, a5, s3, cont);
        p2 = new Predicates.dollar_plus_3(a2, s3, a6, p1);
        p3 = new Predicates.Line_3(a2, a5, s3, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_minus_3(a1, s3, a5, p4);
    }
}

sealed class Close_Line_4_7 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("rightleft");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("left");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a6, a1, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s3, a6, p2);
        p4 = new Predicates.Line_3(a2, a1, s3, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_plus_3(a1, s3, a5, p5);
    }
}

sealed class Close_Line_4_8 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("right");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a6, a1, s3, cont);
        p2 = new Predicates.dollar_plus_3(a2, s3, a6, p1);
        p3 = new Predicates.Line_3(a2, a1, s3, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_plus_3(a1, s3, a5, p4);
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Close_Line_4.cs
 * @procedure closeLine/4 in logic.pl
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

public class Close_Line_4 : Predicate {
    static internal readonly Predicate Close_Line_4_1 = new Predicates.Close_Line_4_1();
    static internal readonly Predicate Close_Line_4_2 = new Predicates.Close_Line_4_2();
    static internal readonly Predicate Close_Line_4_3 = new Predicates.Close_Line_4_3();
    static internal readonly Predicate Close_Line_4_4 = new Predicates.Close_Line_4_4();
    static internal readonly Predicate Close_Line_4_5 = new Predicates.Close_Line_4_5();
    static internal readonly Predicate Close_Line_4_6 = new Predicates.Close_Line_4_6();
    static internal readonly Predicate Close_Line_4_7 = new Predicates.Close_Line_4_7();
    static internal readonly Predicate Close_Line_4_8 = new Predicates.Close_Line_4_8();
    static internal readonly Predicate Close_Line_4_sub_1 = new Predicates.Close_Line_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public Close_Line_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Close_Line_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Close_Line_4_1, Close_Line_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "closeLine(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class Close_Line_4_sub_1 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_2 = new Predicates.Close_Line_4_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_2, Close_Line_4_sub_2);
    }
}

sealed class Close_Line_4_sub_2 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_3 = new Predicates.Close_Line_4_sub_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_3, Close_Line_4_sub_3);
    }
}

sealed class Close_Line_4_sub_3 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_4 = new Predicates.Close_Line_4_sub_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_4, Close_Line_4_sub_4);
    }
}

sealed class Close_Line_4_sub_4 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_5 = new Predicates.Close_Line_4_sub_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_5, Close_Line_4_sub_5);
    }
}

sealed class Close_Line_4_sub_5 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_6 = new Predicates.Close_Line_4_sub_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_6, Close_Line_4_sub_6);
    }
}

sealed class Close_Line_4_sub_6 : Close_Line_4 {
    static internal readonly Predicate Close_Line_4_sub_7 = new Predicates.Close_Line_4_sub_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Close_Line_4_7, Close_Line_4_sub_7);
    }
}

sealed class Close_Line_4_sub_7 : Close_Line_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Close_Line_4_8);
    }
}

sealed class Close_Line_4_1 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("updown");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("down");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a2, a5, s3, p1);
        p3 = new Predicates.Line_3(a6, a5, s3, p2);
        p4 = new Predicates.dollar_plus_3(a2, s1, a6, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_minus_3(a1, s1, a5, p5);
    }
}

sealed class Close_Line_4_2 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("up");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a2, a5, s3, cont);
        p2 = new Predicates.Line_3(a6, a5, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s1, a6, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_minus_3(a1, s1, a5, p4);
    }
}

sealed class Close_Line_4_3 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("downup");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("up");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a2, a1, s3, p1);
        p3 = new Predicates.Line_3(a6, a1, s3, p2);
        p4 = new Predicates.dollar_plus_3(a2, s1, a6, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_plus_3(a1, s1, a5, p5);
    }
}

sealed class Close_Line_4_4 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("down");
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a2, a1, s3, cont);
        p2 = new Predicates.Line_3(a6, a1, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s1, a6, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_plus_3(a1, s1, a5, p4);
    }
}

sealed class Close_Line_4_5 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("leftright");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("right");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a6, a5, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s3, a6, p2);
        p4 = new Predicates.Line_3(a2, a5, s3, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_minus_3(a1, s3, a5, p5);
    }
}

sealed class Close_Line_4_6 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("left");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a6, a5, s3, cont);
        p2 = new Predicates.dollar_plus_3(a2, s3, a6, p1);
        p3 = new Predicates.Line_3(a2, a5, s3, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_minus_3(a1, s3, a5, p4);
    }
}

sealed class Close_Line_4_7 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("rightleft");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);
    static internal readonly SymbolTerm s4 = SymbolTerm.MakeSymbol("left");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Close_Line_4(a1, a2, s1, s4, cont);
        p2 = new Predicates.Line_3(a6, a1, s3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s3, a6, p2);
        p4 = new Predicates.Line_3(a2, a1, s3, p3);
        p5 = new Predicates.Line_3(a5, a2, s1, p4);
        return new Predicates.dollar_plus_3(a1, s3, a5, p5);
    }
}

sealed class Close_Line_4_8 : Close_Line_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly SymbolTerm s2 = SymbolTerm.MakeSymbol("right");
    static internal readonly IntegerTerm s3 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a3, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a4, engine.trail) ) return engine.fail();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        p1 = new Predicates.Line_3(a6, a1, s3, cont);
        p2 = new Predicates.dollar_plus_3(a2, s3, a6, p1);
        p3 = new Predicates.Line_3(a2, a1, s3, p2);
        p4 = new Predicates.Line_3(a5, a2, s1, p3);
        return new Predicates.dollar_plus_3(a1, s3, a5, p4);
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
