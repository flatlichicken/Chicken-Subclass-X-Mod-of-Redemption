using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ChickensubclassXRedemption.Content
{
    public static class ChickenSCElementalDamage
    {
        public static bool[] ProjArcane = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemArcane = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjFire = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemFire = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjHoly = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemHoly = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjShadow = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemShadow = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjNature = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemNature = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjPsychic = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemPsychic = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjCelestial = ProjectileID.Sets.Factory.CreateBoolSet();
        public static bool[] ItemCelestial = ItemID.Sets.Factory.CreateBoolSet();

        public static bool[] ProjExplosive = ProjectileID.Sets.Factory.CreateBoolSet();

        private static readonly string[] ArcaneProjectileNames = new string[]
        {
            "MagicChickenProjectile",
            "PrismaticChickenProjectile",
            "SpookyChickenProjectile",
            "ChaosChickenProjectile"
        };

        private static readonly string[] ArcaneItemNames = new string[]
        {
            "MagicChicken",
            "PrismaticChicken",
            "SpookyChicken",
            "ChaosChicken"
        };

        private static readonly string[] FireProjectileNames = new string[]
        {
            "ChickenFireFeatherProjectile",
            "SolarChickenProjectile"
        
        };

        private static readonly string[] FireItemNames = new string[]
        {
            "FireChicken",
            "SolarChicken",
        };

        private static readonly string[] HolyProjectileNames = new string[]
        {
            "PrismaticChickenProjectile",
            "HolyChickenProjectile",
            "TrueHolyChickenProjectile"
        
        };

        private static readonly string[] HolyItemNames = new string[]
        {
            "PrismaticChicken",
            "HolyChicken",
            "TrueHolyChicken"
        };

        private static readonly string[] ShadowProjectileNames = new string[]
        {
            "EvilChickenProjectile",
            "DarkChickenProjectile",
            "TrueDarkChickenProjectile"
        
        };

        private static readonly string[] ShadowItemNames = new string[]
        {
            "EvilChicken",
            "DarkChicken",
            "TrueDarkChicken"
        };

        private static readonly string[] NatureProjectileNames = new string[]
        {
            "RedJunglefowlProjectile",
            
        };

        private static readonly string[] NatureItemNames = new string[]
        {
            "RedJunglefowl"
        };

        private static readonly string[] PsychicProjectileNames = new string[]
        {
            "ReaperChickenProjectile"
            
        };

        private static readonly string[] PsychicItemNames = new string[]
        {
            "ReaperChicken"
        };

        private static readonly string[] CelestialProjectileNames = new string[]
        {
            "SolarChickenProjectile",
            "PrismaticChickenProjectile",
            "ZenithChickenProjectile"
            
        };

        private static readonly string[] CelestialItemNames = new string[]
        {
            "SolarChicken",
            "PrismaticChicken",
            "ZenithChicken"
        };

        private static readonly string[] ExplosiveProjectileNames = new string[]
        {
            "SolarChickenProjectile",
            "ExplosiveChickenProjectile",
            "NuclearChickenProjectile"
            
        };

        public static void LoadCrossModProjectiles()
        {
            if (ModLoader.TryGetMod("Chickensubclass", out Mod chickenSubclass))
            {
                foreach (string name in ArcaneProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjArcane[proj.Type] = true;
                    }
                }

                foreach (string name in ArcaneItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemArcane[item.Type] = true;
                    }
                }

                foreach (string name in FireProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjFire[proj.Type] = true;
                    }
                }

                foreach (string name in FireItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemFire[item.Type] = true;
                    }
                }

                foreach (string name in HolyProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjHoly[proj.Type] = true;
                    }
                }

                foreach (string name in HolyItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemHoly[item.Type] = true;
                    }
                }

                foreach (string name in ShadowProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjShadow[proj.Type] = true;
                    }
                }

                foreach (string name in ShadowItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemShadow[item.Type] = true;
                    }
                }

                foreach (string name in NatureProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjNature[proj.Type] = true;
                    }
                }

                foreach (string name in NatureItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemNature[item.Type] = true;
                    }
                }

                foreach (string name in PsychicProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjPsychic[proj.Type] = true;
                    }
                }

                foreach (string name in PsychicItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemPsychic[item.Type] = true;
                    }
                }

                foreach (string name in CelestialProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjCelestial[proj.Type] = true;
                    }
                }

                foreach (string name in CelestialItemNames)
                {
                    if (chickenSubclass.TryFind(name, out ModItem item))
                    {
                        ItemCelestial[item.Type] = true;
                    }
                }

                foreach (string name in ExplosivelProjectileNames)
                {
                    if (chickenSubclass.TryFind(name, out ModProjectile proj))
                    {
                        ProjExplosive[proj.Type] = true;
                    }
                }
            }
        }
    }
}
