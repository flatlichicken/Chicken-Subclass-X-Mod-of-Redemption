using Terraria.ModLoader;
using Redemption.Globals;
using Chickensubclass.Content.Projectiles;
using Chickensubclass.Content.Items;

namespace ChickensubclassXRedemption.Content
{
    public class ChickenSCGlobalProjectile : GlobalProjectile
    {
        public override void SetStaticDefaults()
        {
            ElementID.ProjArcane[ModContent.ProjectileType<MagicChickenProjectile>()] = true;
            ElementID.ProjArcane[ModContent.ProjectileType<PrismaticChickenProjectile>()] = true;
            ElementID.ProjArcane[ModContent.ProjectileType<SpookyChickenProjectile>()] = true;
            ElementID.ProjArcane[ModContent.ProjectileType<ChaosChickenProjectile>()] = true;

            ElementID.ProjFire[ModContent.ProjectileType<ChickenFireFeatherProjectile>()] = true;
            ElementID.ProjFire[ModContent.ProjectileType<SolarChickenProjectile>()] = true;

            ElementID.ProjHoly[ModContent.ProjectileType<HolyChickenProjectile>()] = true;
            ElementID.ProjHoly[ModContent.ProjectileType<TrueHolyChickenProjectile>()] = true;
            ElementID.ProjHoly[ModContent.ProjectileType<PrismaticChickenProjectile>()] = true;

            ElementID.ProjShadow[ModContent.ProjectileType<EvilChickenProjectile>()] = true;
            ElementID.ProjShadow[ModContent.ProjectileType<DarkChickenProjectile>()] = true;
            ElementID.ProjShadow[ModContent.ProjectileType<TrueDarkChickenProjectile>()] = true;

            ElementID.ProjNature[ModContent.ProjectileType<RedJunglefowlProjectile>()] = true;
            //ElementID.ProjPsychic[ModContent.ProjectileType<ReaperChickenProjectile>()] = true;

            ElementID.ProjCelestial[ModContent.ProjectileType<SolarChickenProjectile>()] = true;
            ElementID.ProjCelestial[ModContent.ProjectileType<PrismaticChickenProjectile>()] = true;
            ElementID.ProjCelestial[ModContent.ProjectileType<ZenithChickenProjectile>()] = true;

            ElementID.ProjExplosive[ModContent.ProjectileType<SolarChickenProjectile>()] = true;
            ElementID.ProjExplosive[ModContent.ProjectileType<ExplosiveChickenProjectile>()] = true;
            ElementID.ProjExplosive[ModContent.ProjectileType<NuclearChickenProjectile>()] = true;
        }
    }
}