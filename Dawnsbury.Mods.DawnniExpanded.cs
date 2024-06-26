using Dawnsbury.Core.CharacterBuilder.Spellcasting;
using Dawnsbury.Core.Mechanics.Enumerations;
using Dawnsbury.Modding;
using Dawnsbury.Mods.DawnniExpanded.Backgrounds;
using Dawnsbury.Mods.DawnniExpanded.Ancestries;


namespace Dawnsbury.Mods.DawnniExpanded;
public class DawnniExpanded
{
    public static Trait DETrait;
    public static Trait HomebrewTrait;

    [DawnsburyDaysModMainMethod]
    public static void LoadMod()
    {
        DETrait = ModManager.RegisterTrait(
            "DawnniEx",
            new TraitProperties("DawnniEx", true)
            );
        HomebrewTrait = ModManager.RegisterTrait(
            "Homebrew",
            new TraitProperties("Homebrew", true)
            );



        NewSkills.LoadMod();

        SpellHorizonThunderSphere.LoadMod();
        SpellAnimatedAssualt.LoadMod();
        SpellScorchingRay.LoadMod();
        SpellEndure.LoadMod();
        SpellFalseLife.LoadMod();
        SpellRousingSplash.LoadMod();
        SpellSuddenBolt.LoadMod();
        SpellCounterPerformance.LoadMod();
        SpellHymnOfHealing.LoadMod();
        SpellTripleTime.LoadMod();
        SpellInspireCourage.LoadMod();
        SpellHeightenedFear.LoadMod();
        SpellConcordantChoir.LoadMod();
        SpellRayofEnfeeblement.LoadMod();
        SpellInnerRadianceTorrent.LoadMod();

        FeatBattleMedicine.LoadMod();
        FeatPowerfulLeap.LoadMod();

        BackgroundFieldMedic.LoadMod();
        BackgroundMartialDisciple.LoadMod();
        BackgroundWarrior.LoadMod();
        BackgroundDancer.LoadMod();

        ActionLeap.LoadMod();

        ItemStaffofSpellPotency.LoadMod();
        TraitMutagens.LoadMod();
        ItemMutagens.LoadMod();
        FeatDuelingParry.LoadMod();

        FeatArchetype.LoadMod();
        MonsterBadger.LoadMod();

        GenerateHeightenedScrolls.LoadMod();
        //KinTest.LoadMod();

        VersatileHertiages.LoadMod();
        //AncestryHalfling.LoadMod();
        AncestryDragon.LoadMod();
        Bard.LoadMod();


    }


}