﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Core.NWScript.Enum.VisualEffect;
using SWLOR.Game.Server.Service;
using SWLOR.Game.Server.Service.AbilityService;
using SWLOR.Game.Server.Service.PerkService;
using SWLOR.Game.Server.Service.SkillService;
using SWLOR.Game.Server.Service.StatusEffectService;

namespace SWLOR.Game.Server.Feature.AbilityDefinition.Force
{
    public class BenevolenceAbilityDefinition : IAbilityListDefinition
    {
        private readonly AbilityBuilder _builder = new();

        public Dictionary<FeatType, AbilityDetail> BuildAbilities()
        {
            Benevolence1();
            Benevolence2();
            Benevolence3();

            return _builder.Build();
        }

        private void Impact(uint activator, uint target, int amount)
        {
            var willBonus = GetAbilityModifier(AbilityType.Willpower, activator) * 4;
            amount += willBonus;

            ApplyEffectToObject(DurationType.Instant, EffectHeal(amount), target);
            ApplyEffectToObject(DurationType.Instant, EffectVisualEffect(VisualEffect.Vfx_Imp_Healing_M), target);

            Enmity.ModifyEnmityOnAll(activator, amount);
            CombatPoint.AddCombatPointToAllTagged(activator, SkillType.Force, 3);
        }

        private void Benevolence1()
        {
            _builder.Create(FeatType.Benevolence1, PerkType.Benevolence)
                .Name("Benevolence I")
                .HasRecastDelay(RecastGroup.Benevolence, 30f)
                .RequirementFP(4)
                .IsCastedAbility()
                .UsesAnimation(Animation.LoopingConjure1)
                .DisplaysVisualEffectWhenActivating()
                .HasImpactAction((activator, target, level, location) =>
                {
                    Impact(activator, target, 40);
                });
        }

        private void Benevolence2()
        {
            _builder.Create(FeatType.Benevolence2, PerkType.Benevolence)
                .Name("Benevolence II")
                .HasRecastDelay(RecastGroup.Benevolence, 30f)
                .RequirementFP(6)
                .IsCastedAbility()
                .UsesAnimation(Animation.LoopingConjure1)
                .DisplaysVisualEffectWhenActivating()
                .HasImpactAction((activator, target, level, location) =>
                {
                    Impact(activator, target, 80);
                });
        }

        private void Benevolence3()
        {
            _builder.Create(FeatType.Benevolence3, PerkType.Benevolence)
                .Name("Benevolence III")
                .HasRecastDelay(RecastGroup.Benevolence, 30f)
                .RequirementFP(8)
                .IsCastedAbility()
                .UsesAnimation(Animation.LoopingConjure1)
                .DisplaysVisualEffectWhenActivating()
                .HasImpactAction((activator, target, level, location) =>
                {
                    Impact(activator, target, 120);
                });
        }
    }
}