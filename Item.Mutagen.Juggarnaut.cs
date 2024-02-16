using Dawnsbury.Core;
using Dawnsbury.Core.Mechanics;
using Dawnsbury.Core.Mechanics.Core;
using Dawnsbury.Core.Mechanics.Enumerations;
using Dawnsbury.Core.Mechanics.Treasure;
using Dawnsbury.Display.Illustrations;
using Dawnsbury.Modding;
using Dawnsbury.Audio;
using Dawnsbury.Core.CombatActions;
using Dawnsbury.Core.Creatures;
using Dawnsbury.Core.Mechanics.Targeting;
using Dawnsbury.Core.Possibilities;
using Dawnsbury.Core.CharacterBuilder.FeatsDb.Common;
using Dawnsbury.Core.Roller;




namespace Dawnsbury.Mods.DawnniExpanded;

public static class ItemMutagenJuggernaut
{
    public static void LoadMod()
    {
        ModdedIllustration illustrationJuggernaut= new ModdedIllustration("DawnniburyExpandedAssets/JuggernautMutagen.png");

        ItemName JuggernautMutagenLesser = ModManager.RegisterNewItemIntoTheShop("Juggernaut Mutagen (Lesser)", itemName =>

            new Item(itemName, illustrationJuggernaut, "Juggernaut Mutagen (Lesser)", 1, 4, Trait.Elixir, TraitMutagens.MutagenTrait, TraitMutagens.PolymorphTrait, Trait.Alchemical,DawnniExpanded.DETrait)
            {
                Description = "After you drink this mutagen, your body becomes thick and sturdy. You exhibit a healthy glow, though you tend to be ponderous and unobservant.\n\n{b}Benefit{/b} You gain a +1 item bonus to Fortitude saves and 5 temporary Hit Points.\n\n{b}Drawback{/b} You take a –2 penalty to Will saves and Perception checks.\n\n",
                
                DrinkableEffect = (CombatAction ca, Creature self) => {

                    self.GainTemporaryHP(5);
                    QEffect JuggernautMutagenEffect = new QEffect("Juggernaut Mutagen","You are benefitng from a Juggernaut Mutagen",ExpirationCondition.Never,self,illustrationJuggernaut){
                    
                    PreventTargetingBy = newAttack => newAttack.Traits.Contains(TraitMutagens.PolymorphTrait) == false ? null : "Target is already under a Polymorph effect",
                    PreventTakingAction = newAttack => (newAttack.Traits.Contains(TraitMutagens.PolymorphTrait) == false) && newAttack.ActionId != ActionId.Drink ? null : "Target is already under a Polymorph effect",
                    CountsAsABuff = true,
                    
                    BonusToDefenses = (QEffect effect, CombatAction attack, Defense defense) => 
                    {
                         if (defense == Defense.Will)
                         {
                            return new Bonus(-2, BonusType.Item, "Juggernaut Mutagen");
                         } else if (defense == Defense.Fortitude)
                         {
                            return new Bonus(1, BonusType.Item, "Juggernaut Mutagen");
                         } else if (defense == Defense.Perception)
                         {
                            return new Bonus(-2, BonusType.Item, "Juggernaut Mutagen");
                         } else return null;

                         
                    },

                    BonusToAttackRolls = (qf, attack, de) => {

                        if (attack.ActionId.Equals(ActionId.Seek)) {
                            return new Bonus(2, BonusType.Item, "Juggernaut Mutagen");
                        } else return null;
                    },
                    
                    
                   
                    };

                    

                    self.AddQEffect(JuggernautMutagenEffect);
                
                }
                
                
            }
            
            );
            

            ItemName JuggernautMutagenModerate = ModManager.RegisterNewItemIntoTheShop("Juggernaut Mutagen (Moderate)", itemName =>

            new Item(itemName, illustrationJuggernaut, "Juggernaut Mutagen (Moderate)", 3, 12, Trait.Elixir, TraitMutagens.MutagenTrait, TraitMutagens.PolymorphTrait, Trait.Alchemical,DawnniExpanded.DETrait)
            {
                Description = "After you drink this mutagen, your body becomes thick and sturdy. You exhibit a healthy glow, though you tend to be ponderous and unobservant.\n\n{b}Benefit{/b} You gain a +2 item bonus to Fortitude saves and 10 temporary Hit Points.\n\n{b}Drawback{/b} You take a –2 penalty to Will saves and Perception checks.\n\n",
                
                DrinkableEffect = (CombatAction ca, Creature self) => {

                    self.GainTemporaryHP(10);
                    QEffect JuggernautMutagenEffect = new QEffect("Juggernaut Mutagen","You are benefitng from a Juggernaut Mutagen",ExpirationCondition.Never,self,illustrationJuggernaut){
                    
                    PreventTargetingBy = newAttack => newAttack.Traits.Contains(TraitMutagens.PolymorphTrait) == false ? null : "Target is already under a Polymorph effect",
                    PreventTakingAction = newAttack => (newAttack.Traits.Contains(TraitMutagens.PolymorphTrait) == false) && newAttack.ActionId != ActionId.Drink ? null : "Target is already under a Polymorph effect",
                    CountsAsABuff = true,

                    BonusToDefenses = (QEffect effect, CombatAction attack, Defense defense) => 
                    {
                         if (defense == Defense.Will)
                         {
                            return new Bonus(-2, BonusType.Item, "Juggernaut Mutagen");
                         } else if (defense == Defense.Fortitude)
                         {
                            return new Bonus(2, BonusType.Item, "Juggernaut Mutagen");
                         } else if (defense == Defense.Perception)
                         {
                            return new Bonus(-2, BonusType.Item, "Juggernaut Mutagen");
                         } else return null;

                         
                    },

                    BonusToAttackRolls = (qf, attack, de) => {

                        if (attack.ActionId.Equals(ActionId.Seek)) {
                            return new Bonus(2, BonusType.Item, "Juggernaut Mutagen");
                        } else return null;
                    },
                    };

                    self.AddQEffect(JuggernautMutagenEffect);
                
                }
                
                
            }
            
            );
          
       

        #pragma warning restore CS0618 // Type or member is obsolete
    }
}