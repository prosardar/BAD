<<<<<<< HEAD
/*
 * *** Please do not edit ! ***
 * @(#) Belong_2.cs
 * @procedure belong/2 in logic.pl
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

public class Belong_2 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Belong_2 );
    static internal readonly Predicate Belong_2_1 = new Predicates.Belong_2_1();
    static internal readonly Predicate Belong_2_2 = new Predicates.Belong_2_2();
    static internal readonly Predicate Belong_2_3 = new Predicates.Belong_2_3();
    static internal readonly Predicate Belong_2_sub_1 = new Predicates.Belong_2_sub_1();

    public Term arg1, arg2;

    public Belong_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Belong_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Belong_2_1, Belong_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "belong(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Belong_2_sub_1 : Belong_2 {
    static internal readonly Predicate Belong_2_sub_2 = new Predicates.Belong_2_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Belong_2_2, Belong_2_sub_2);
    }
}

sealed class Belong_2_sub_2 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Belong_2_3);
    }
}

sealed class Belong_2_1 : Belong_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_fail_0(p1);
        return new Predicates.dollar_getLevel_1(a3, p2);
    }
}

sealed class Belong_2_2 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            if ( !a1.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            if ( !a2.Unify(new ListTerm(a1, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Belong_2_3 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(engine.makeVariable(), a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a1;
        engine.aregs[2] = a3;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

=======
/*
 * *** Please do not edit ! ***
 * @(#) Belong_2.cs
 * @procedure belong/2 in logic.pl
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

public class Belong_2 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Belong_2 );
    static internal readonly Predicate Belong_2_1 = new Predicates.Belong_2_1();
    static internal readonly Predicate Belong_2_2 = new Predicates.Belong_2_2();
    static internal readonly Predicate Belong_2_3 = new Predicates.Belong_2_3();
    static internal readonly Predicate Belong_2_sub_1 = new Predicates.Belong_2_sub_1();

    public Term arg1, arg2;

    public Belong_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Belong_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(Belong_2_1, Belong_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "belong(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Belong_2_sub_1 : Belong_2 {
    static internal readonly Predicate Belong_2_sub_2 = new Predicates.Belong_2_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Belong_2_2, Belong_2_sub_2);
    }
}

sealed class Belong_2_sub_2 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Belong_2_3);
    }
}

sealed class Belong_2_1 : Belong_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_fail_0(p1);
        return new Predicates.dollar_getLevel_1(a3, p2);
    }
}

sealed class Belong_2_2 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            if ( !a1.Unify(((ListTerm)a2).car, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            if ( !a2.Unify(new ListTerm(a1, engine.makeVariable()), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return cont;
    }
}

sealed class Belong_2_3 : Belong_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(engine.makeVariable(), a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = a1;
        engine.aregs[2] = a3;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

>>>>>>> 9915472eed58a04a5b27fabbdf64766cc2ebff48
