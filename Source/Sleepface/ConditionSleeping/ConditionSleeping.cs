using System.Xml;
using Verse;
using AlienRace.ExtendedGraphics;
using RimWorld;


// ConditionSleeping 클래스 작성
public class ConditionSleeping : Condition
{
    public new const string XmlNameParseKey = "Sleeping";

    public bool sleeping = true;

    public override bool Satisfied(ExtendedGraphicsPawnWrapper pawn, ref ResolveData data)
    {
        return this.sleeping == !pawn.WrappedPawn.Awake();
    }
}
