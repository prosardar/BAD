/*
 * *** Please do not edit ! ***
 * @(#) Team_1.cs
 * @procedure team/1 in logic.pl
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

public class Team_1 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Team_1_1 = new Predicates.Team_1_1();
    static internal readonly Predicate Team_1_2 = new Predicates.Team_1_2();
    static internal readonly Predicate Team_1_var = new Predicates.Team_1_var();

    public Term arg1;

    public Team_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Team_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   Team_1_var,
                                   dollar_fail_0,
                                   Team_1_var,
                                   dollar_fail_0,
                                   dollar_fail_0
                                   );
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "team(" + arg1 + ")";
    }
}

sealed class Team_1_var : Team_1 {
    static internal readonly Predicate Team_1_var_1 = new Predicates.Team_1_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Team_1_1, Team_1_var_1);
    }
}

sealed class Team_1_var_1 : Team_1 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Team_1_2);
    }
}

sealed class Team_1_1 : Team_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("yellow");

    public override Predicate exec( Prolog engine ) {
        Term a1;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Team_1_2 : Team_1 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("red");

    public override Predicate exec( Prolog engine ) {
        Term a1;
        a1 = engine.aregs[1].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        return cont;
    }
}
}