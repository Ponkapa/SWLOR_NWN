﻿using System.Collections.Generic;
using SWLOR.Game.Server.Core.NWScript.Enum;
using SWLOR.Game.Server.Service;
using SWLOR.Game.Server.Service.AbilityService;
using SWLOR.Game.Server.Service.PerkService;

namespace SWLOR.Game.Server.Feature.AbilityDefinition.OneHanded
{
    public class StrongStyleLightsaberAbilityDefinition : IAbilityListDefinition
    {
        private readonly AbilityBuilder _builder = new();

        public Dictionary<FeatType, AbilityDetail> BuildAbilities()
        {
            StrongStyleLightsaber();

            return _builder.Build();
        }

        private void DoToggle(uint activator, AbilityToggleType type)
        {
            var isToggled = !Ability.IsAbilityToggled(activator, type);
            Ability.ToggleAbility(activator, type, isToggled);

            if (isToggled)
            {
                SendMessageToPC(activator, ColorToken.Green("Strong Style (Lightsaber) enabled"));
            }
            else
            {
                SendMessageToPC(activator, ColorToken.Red("Strong Style (Lightsaber) disabled"));
            }
        }

        private void StrongStyleLightsaber()
        {
            _builder.Create(FeatType.StrongStyleLightsaber, PerkType.StrongStyleLightsaber)
                .Name("Strong Style (Lightsaber)")
                .IsCastedAbility()
                .UnaffectedByHeavyArmor()
                .HideActivationMessage()
                .HasImpactAction((activator, target, level, location) =>
                {
                    switch (level)
                    {
                        case 1:
                            DoToggle(activator, AbilityToggleType.StrongStyleLightsaber1);
                            break;
                        case 2:
                            DoToggle(activator, AbilityToggleType.StrongStyleLightsaber2);
                            break;
                        case 3:
                            DoToggle(activator, AbilityToggleType.StrongStyleLightsaber3);
                            break;
                        case 4:
                            DoToggle(activator, AbilityToggleType.StrongStyleLightsaber4);
                            break;
                        case 5:
                            DoToggle(activator, AbilityToggleType.StrongStyleLightsaber5);
                            break;
                    }
                });
        }
    }
}
