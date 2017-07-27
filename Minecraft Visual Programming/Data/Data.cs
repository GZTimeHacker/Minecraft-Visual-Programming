using System.Linq;

namespace Minecraft_Visual_Programming.Data
{
    public class Data
    {
        //触发器
        private string[] Trigger =
        {
            Resources.Trigger.bred_animals,
            Resources.Trigger.brewed_potion,
            Resources.Trigger.changed_dimension,
            Resources.Trigger.construct_beacon,
            Resources.Trigger.consume_item,
            Resources.Trigger.cured_zombie_villager,
            Resources.Trigger.effects_changed,
            Resources.Trigger.enchanted_item,
            Resources.Trigger.enter_block,
            Resources.Trigger.entity_hurt_player,
            Resources.Trigger.entity_killed_player,
            Resources.Trigger.impossible,
            Resources.Trigger.inventory_changed,
            Resources.Trigger.item_durability_changed,
            Resources.Trigger.levitation,
            Resources.Trigger.location,
            Resources.Trigger.nether_travel,
            Resources.Trigger.placed_block,
            Resources.Trigger.player_hurt_entity,
            Resources.Trigger.player_killed_entity,
            Resources.Trigger.recipe_unlocked,
            Resources.Trigger.slept_in_bed,
            Resources.Trigger.summoned_entity,
            Resources.Trigger.tame_animal,
            Resources.Trigger.tick,
            Resources.Trigger.used_ender_eye,
            Resources.Trigger.used_totem,
            Resources.Trigger.villager_trade,
        };
        private string[] TriggerDescribe =
{
            Resources.TGDescribe.bred_animals,
            Resources.TGDescribe.brewed_potion,
            Resources.TGDescribe.changed_dimension,
            Resources.TGDescribe.construct_beacon,
            Resources.TGDescribe.consume_item,
            Resources.TGDescribe.cured_zombie_villager,
            Resources.TGDescribe.effects_changed,
            Resources.TGDescribe.enchanted_item,
            Resources.TGDescribe.enter_block,
            Resources.TGDescribe.entity_hurt_player,
            Resources.TGDescribe.entity_killed_player,
            Resources.TGDescribe.impossible,
            Resources.TGDescribe.inventory_changed,
            Resources.TGDescribe.item_durability_changed,
            Resources.TGDescribe.levitation,
            Resources.TGDescribe.location,
            Resources.TGDescribe.nether_travel,
            Resources.TGDescribe.placed_block,
            Resources.TGDescribe.player_hurt_entity,
            Resources.TGDescribe.player_killed_entity,
            Resources.TGDescribe.recipe_unlocked,
            Resources.TGDescribe.slept_in_bed,
            Resources.TGDescribe.summoned_entity,
            Resources.TGDescribe.tame_animal,
            Resources.TGDescribe.tick,
            Resources.TGDescribe.used_ender_eye,
            Resources.TGDescribe.used_totem,
            Resources.TGDescribe.villager_trade,
        };
        /// <summary>
        /// 获取单个Trigger及其描述
        /// </summary>
        /// <param name="i">Triggler序号</param>
        /// <returns name="r">单个Trigger及其描述</returns>
        public string[] GetTrigger(int i)
        {
            if (i < 0 || i > (Trigger.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Trigger[i], TriggerDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Trigger数量
        /// </summary>
        /// <returns>Trigger数量</returns>
        public int GetTriggerCount() { return Trigger.Count(); }
        //边框形式
        private string[] Frame =
        {
            Resources.Frame.challenge,
            Resources.Frame.goal,
            Resources.Frame.task
        };
        private string[] FrameDescribe =
        {
            Resources.Frame.D_challenge,
            Resources.Frame.D_goal,
            Resources.Frame.D_task,
        };
        /// <summary>
        /// 获取单个Frame及其描述
        /// </summary>
        /// <param name="i">Frame序号</param>
        /// <returns></returns>
        public string[] GetFrame(int i)
        {
            if (i < 0 || i > (Frame.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Frame[i], FrameDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Frame数量
        /// </summary>
        /// <returns></returns>
        public int GetFrameCount() { return Frame.Count(); }
        //效果
        private string[] Effects = {
                                "minecraft:saturation",
                                "minecraft:wither",
                                "minecraft:glowing",
                                "minecraft:nausea",
                                "minecraft:slowness",
                                "minecraft:hunger",
                                "minecraft:haste",
                                "minecraft:fire_resistance",
                                "minecraft:resistance",
                                "minecraft:strength",
                                "minecraft:unluck",
                                "minecraft:levitation",
                                "minecraft:absorption",
                                "minecraft:regeneration",
                                "minecraft:health_boost",
                                "minecraft:blindness",
                                "minecraft:water_breathing",
                                "minecraft:instant_damage",
                                "minecraft:instant_health",
                                "minecraft:speed",
                                "minecraft:jump_boost",
                                "minecraft:mining_fatigue",
                                "minecraft:luck",
                                "minecraft:weakness",
                                "minecraft:night_vision",
                                "minecraft:invisibility",
                                "minecraft:poison"
                             };
        private string[] EffectDescribe = {
                                "饱和",
                                "凋零",
                                "发光",
                                "反胃",
                                "缓慢",
                                "饥饿",
                                "急迫",
                                "抗火",
                                "抗性提升",
                                "力量",
                                "霉运",
                                "飘浮",
                                "伤害吸收",
                                "生命恢复",
                                "生命提升",
                                "失明",
                                "水下呼吸",
                                "瞬间伤害",
                                "瞬间治疗",
                                "速度",
                                "跳跃提升",
                                "挖掘疲劳",
                                "幸运",
                                "虚弱",
                                "夜视",
                                "隐身",
                                "中毒"
                             };
        /// <summary>
        /// 获取单个Effect及其描述
        /// </summary>
        /// <param name="i">Effect序号</param>
        /// <returns></returns>
        public string[] GetEffect(int i)
        {
            if (i < 0 || i > (Effects.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Effects[i], EffectDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Effect数量
        /// </summary>
        /// <returns></returns>
        public int GetEffectCount() { return Effects.Count(); }
        //实体
        string[] Entity = {
                            "Player",
                            "Item",
                            "Ozelot",
                            "PolarBear",
                            "Bat",
                            "Boat",
                            "Villager",
                            "PrimedTnt",
                            "WitherBoss",
                            "WitherSkull",
                            "FallingSand",
                            "CaveSpider",
                            "Silverfish",
                            "Ghast",
                            "Guardian",
                            "Painting",
                            "Fireball",
                            "Chicken",
                            "Arrow",
                            "TippedArrow",
                            "SpectralArrow",
                            "Zombie",
                            "PigZombie",
                            "XPOrb",
                            "Giant",
                            "Skeleton",
                            "MinecartTNT",
                            "MinecartFurnace",
                            "MinecartRideable",
                            "MinecartHopper",
                            "MinecartCommandBlock",
                            "MinecartSpawner",
                            "Minecart",
                            "MinecartChest",
                            "ArmorStand",
                            "Wolf",
                            "Blaze",
                            "EntityHorse",
                            "MushroomCow",
                            "EnderDragon",
                            "DragonFireball",
                            "Endermite",
                            "Enderman",
                            "EnderCrystal",
                            "EyeOfEnderSignal",
                            "Squid",
                            "Cow",
                            "Witch",
                            "Creeper",
                            "Shulker",
                            "ShulkerBullet",
                            "ThrownEgg",
                            "ThrownExpBottle",
                            "ThrownEnderpearl",
                            "ThrownPotion",
                            "LightningBolt",
                            "Slime",
                            "LeashKnot",
                            "VillagerGolem",
                            "Rabbit",
                            "ItemFrame",
                            "SmallFireball",
                            "Snowball",
                            "SnowMan",
                            "FireworksRocketEntity",
                            "LavaSlime",
                            "Sheep",
                            "AreaEffectCloud",
                            "Spider",
                            "Pig"
                         };
        string[] EntityDescribe = {
                                    "玩家",
                                    "物品",
                                    "豹猫",
                                    "北极熊",
                                    "蝙蝠",
                                    "船",
                                    "村民",
                                    "点燃的TNT",
                                    "凋零",
                                    "凋零骷髅",
                                    "掉落沙",
                                    "洞穴蜘蛛",
                                    "蠹虫",
                                    "恶魂",
                                    "海底神殿守卫者",
                                    "画",
                                    "火焰球",
                                    "鸡",
                                    "箭矢",
                                    "箭矢 - 药水箭",
                                    "箭矢 - 光箭",
                                    "僵尸",
                                    "僵尸猪人",
                                    "经验珠",
                                    "巨型僵尸",
                                    "骷髅弓箭手",
                                    "矿车 - TNT矿车",
                                    "矿车 - 动力矿车",
                                    "矿车 - 可乘矿车",
                                    "矿车 - 漏斗矿车",
                                    "矿车 - 命令方块矿车",
                                    "矿车 - 刷怪笼矿车",
                                    "矿车 - 新版本已弃用",
                                    "矿车 - 运输矿车",
                                    "盔甲架",
                                    "狼",
                                    "烈焰人",
                                    "马",
                                    "蘑菇牛",
                                    "末影龙",
                                    "末影龙火焰弹",
                                    "末影螨",
                                    "末影人",
                                    "末影水晶",
                                    "末影之眼信号",
                                    "墨鱼",
                                    "牛",
                                    "女巫",
                                    "爬行者",
                                    "潜影贝",
                                    "潜影弹",
                                    "扔出的鸡蛋",
                                    "扔出的经验瓶",
                                    "扔出的末影珍珠",
                                    "扔出的药水瓶",
                                    "闪电",
                                    "史莱姆",
                                    "拴绳结",
                                    "铁傀儡",
                                    "兔子",
                                    "物品展示框",
                                    "小火球",
                                    "雪球",
                                    "雪人",
                                    "烟花火箭",
                                    "岩浆史莱姆",
                                    "羊",
                                    "药水云",
                                    "蜘蛛",
                                    "猪"
                                 };
        /// <summary>
        /// 获取单个Entity及其描述
        /// </summary>
        /// <param name="i">Entity序号</param>
        /// <returns></returns>
        public string[] GetEntity(int i)
        {
            if (i < 0 || i > (Entity.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Entity[i], EntityDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Entity数量
        /// </summary>
        /// <returns></returns>
        public int GetEntityCount() { return Entity.Count(); }
        //生物群系
        private string[] Biome =
        {
            Resources.Biome.Beach,
            Resources.Biome.Birch_Forest,
            Resources.Biome.Birch_Forest_Hills,
            Resources.Biome.Birch_Forest_Hills_M,
            Resources.Biome.Birch_Forest_M,
            Resources.Biome.Cold_Beach,
            Resources.Biome.Cold_Taiga,
            Resources.Biome.Cold_Taiga_Hills,
            Resources.Biome.Cold_Taiga_M,
            Resources.Biome.Deep_Ocean,
            Resources.Biome.Desert,
            Resources.Biome.DesertHills,
            Resources.Biome.Desert_M,
            Resources.Biome.Extreme_Hills,
            Resources.Biome.Extreme_Hills_Edge,
            Resources.Biome.Extreme_Hills_M,
            Resources.Biome.Extreme_Hills_plus,
            Resources.Biome.Extreme_Hills_plus_M,
            Resources.Biome.Flower_Forest,
            Resources.Biome.Forest,
            Resources.Biome.ForestHills,
            Resources.Biome.FrozenOcean,
            Resources.Biome.FrozenRiver,
            Resources.Biome.Hell,
            Resources.Biome.Ice_Mountains,
            Resources.Biome.Ice_Plains,
            Resources.Biome.Ice_Plains_Spikes,
            Resources.Biome.Jungle,
            Resources.Biome.JungleEdge,
            Resources.Biome.JungleEdge_M,
            Resources.Biome.JungleHills,
            Resources.Biome.Jungle_M,
            Resources.Biome.Mega_Spruce_Taiga,
            Resources.Biome.Mega_Taiga,
            Resources.Biome.Mega_Taiga_Hills,
            Resources.Biome.Mesa,
            Resources.Biome.Mesa_Bryce,
            Resources.Biome.Mesa_Plateau,
            Resources.Biome.Mesa_Plateau_F,
            Resources.Biome.Mesa_Plateau_F_M,
            Resources.Biome.Mesa_Plateau_M,
            Resources.Biome.MushroomIsland,
            Resources.Biome.MushroomIslandShore,
            Resources.Biome.Ocean,
            Resources.Biome.Plains,
            Resources.Biome.Redwood_Taiga_Hills_M,
            Resources.Biome.River,
            Resources.Biome.Roofed_Forest,
            Resources.Biome.Roofed_Forest_M,
            Resources.Biome.Savanna,
            Resources.Biome.Savanna_M,
            Resources.Biome.Savanna_Plateau,
            Resources.Biome.Savanna_Plateau_M,
            Resources.Biome.Stone_Beach,
            Resources.Biome.Sunflower_Plains,
            Resources.Biome.Swampland,
            Resources.Biome.Swampland_M,
            Resources.Biome.Taiga,
            Resources.Biome.TaigaHills,
            Resources.Biome.Taiga_M,
            Resources.Biome.The_End,
            Resources.Biome.The_Void,
        };
        private string[] BiomeDescribe =
        {
            Resources.BiomeDescribe.Beach,
            Resources.BiomeDescribe.Birch_Forest,
            Resources.BiomeDescribe.Birch_Forest_Hills,
            Resources.BiomeDescribe.Birch_Forest_Hills_M,
            Resources.BiomeDescribe.Birch_Forest_M,
            Resources.BiomeDescribe.Cold_Beach,
            Resources.BiomeDescribe.Cold_Taiga,
            Resources.BiomeDescribe.Cold_Taiga_Hills,
            Resources.BiomeDescribe.Cold_Taiga_M,
            Resources.BiomeDescribe.Deep_Ocean,
            Resources.BiomeDescribe.Desert,
            Resources.BiomeDescribe.DesertHills,
            Resources.BiomeDescribe.Desert_M,
            Resources.BiomeDescribe.Extreme_Hills,
            Resources.BiomeDescribe.Extreme_Hills_Edge,
            Resources.BiomeDescribe.Extreme_Hills_M,
            Resources.BiomeDescribe.Extreme_Hills_plus,
            Resources.BiomeDescribe.Extreme_Hills_plus_M,
            Resources.BiomeDescribe.Flower_Forest,
            Resources.BiomeDescribe.Forest,
            Resources.BiomeDescribe.ForestHills,
            Resources.BiomeDescribe.FrozenOcean,
            Resources.BiomeDescribe.FrozenRiver,
            Resources.BiomeDescribe.Hell,
            Resources.BiomeDescribe.Ice_Mountains,
            Resources.BiomeDescribe.Ice_Plains,
            Resources.BiomeDescribe.Ice_Plains_Spikes,
            Resources.BiomeDescribe.Jungle,
            Resources.BiomeDescribe.JungleEdge,
            Resources.BiomeDescribe.JungleEdge_M,
            Resources.BiomeDescribe.JungleHills,
            Resources.BiomeDescribe.Jungle_M,
            Resources.BiomeDescribe.Mega_Spruce_Taiga,
            Resources.BiomeDescribe.Mega_Taiga,
            Resources.BiomeDescribe.Mega_Taiga_Hills,
            Resources.BiomeDescribe.Mesa,
            Resources.BiomeDescribe.Mesa_Bryce,
            Resources.BiomeDescribe.Mesa_Plateau,
            Resources.BiomeDescribe.Mesa_Plateau_F,
            Resources.BiomeDescribe.Mesa_Plateau_F_M,
            Resources.BiomeDescribe.Mesa_Plateau_M,
            Resources.BiomeDescribe.MushroomIsland,
            Resources.BiomeDescribe.MushroomIslandShore,
            Resources.BiomeDescribe.Ocean,
            Resources.BiomeDescribe.Plains,
            Resources.BiomeDescribe.Redwood_Taiga_Hills_M,
            Resources.BiomeDescribe.River,
            Resources.BiomeDescribe.Roofed_Forest,
            Resources.BiomeDescribe.Roofed_Forest_M,
            Resources.BiomeDescribe.Savanna,
            Resources.BiomeDescribe.Savanna_M,
            Resources.BiomeDescribe.Savanna_Plateau,
            Resources.BiomeDescribe.Savanna_Plateau_M,
            Resources.BiomeDescribe.Stone_Beach,
            Resources.BiomeDescribe.Sunflower_Plains,
            Resources.BiomeDescribe.Swampland,
            Resources.BiomeDescribe.Swampland_M,
            Resources.BiomeDescribe.Taiga,
            Resources.BiomeDescribe.TaigaHills,
            Resources.BiomeDescribe.Taiga_M,
            Resources.BiomeDescribe.The_End,
            Resources.BiomeDescribe.The_Void,
        };
        /// <summary>
        ///  获取单个Biome及其描述
        /// </summary>
        /// <param name="i">Biome序号</param>
        /// <returns></returns>
        public string[] GetBiome(int i)
        {
            if (i < 0 || i > (Biome.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Biome[i], BiomeDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Biome数量
        /// </summary>
        /// <returns></returns>
        public int GetBiomeCount() { return Biome.Count(); }
        //结构
        private string[] Structures =
        {
            Resources.Structures.EndCity,
            Resources.Structures.Fortress,
            Resources.Structures.Mansion,
            Resources.Structures.MineShaft,
            Resources.Structures.Monument,
            Resources.Structures.Stronghold,
            Resources.Structures.Temple,
            Resources.Structures.Village,
        };
        private string[] StructuresDescribe =
{
            Resources.StructuresDescribe.EndCity,
            Resources.StructuresDescribe.Fortress,
            Resources.StructuresDescribe.Mansion,
            Resources.StructuresDescribe.MineShaft,
            Resources.StructuresDescribe.Monument,
            Resources.StructuresDescribe.Stronghold,
            Resources.StructuresDescribe.Temple,
            Resources.StructuresDescribe.Village,
        };
        /// <summary>
        ///  获取单个Structures及其描述
        /// </summary>
        /// <param name="i">Structures序号</param>
        /// <returns></returns>
        public string[] GetStructures(int i)
        {
            if (i < 0 || i > (Structures.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Structures[i], StructuresDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Structures数量
        /// </summary>
        /// <returns></returns>
        public int GetStructuresCount() { return Structures.Count(); }
        //药水数据值
        private string[] Potion =
        {
            Resources.Potion.Awkward_Potion,
            Resources.Potion.Fire_Resistance,
            Resources.Potion.Harming,
            Resources.Potion.Instant_Health,
            Resources.Potion.Invisibility,
            Resources.Potion.Leaping,
            Resources.Potion.Luck,
            Resources.Potion.Mundane_Potion,
            Resources.Potion.Night_Vision,
            Resources.Potion.Poison,
            Resources.Potion.Regeneration,
            Resources.Potion.Slowness,
            Resources.Potion.Strength,
            Resources.Potion.Swiftness,
            Resources.Potion.Thick_Potion,
            Resources.Potion.Water_Bottle,
            Resources.Potion.Water_Breathing,
            Resources.Potion.Weakness,
            Resources.Potion.Harming_II,
            Resources.Potion.Instant_Health_II,
            Resources.Potion.Leaping_II,
            Resources.Potion.Poison_II,
            Resources.Potion.Regeneration_II,
            Resources.Potion.Strength_II,
            Resources.Potion.Swiftness_II,
            Resources.Potion.Long_Fire_Resistance,
            Resources.Potion.Long_Invisibility,
            Resources.Potion.Long_Leaping,
            Resources.Potion.Long_Night_Vision,
            Resources.Potion.Long_Poison,
            Resources.Potion.Long_Regeneration,
            Resources.Potion.Long_Slowness,
            Resources.Potion.Long_Strength,
            Resources.Potion.Long_Swiftness,
            Resources.Potion.Long_Water_Breathing,
            Resources.Potion.Long_Weakness,
        };
        private string[] PotionDescribe =
        {
                        Resources.PotionDescribe.Awkward_Potion,
            Resources.PotionDescribe.Fire_Resistance,
            Resources.PotionDescribe.Harming,
            Resources.PotionDescribe.Instant_Health,
            Resources.PotionDescribe.Invisibility,
            Resources.PotionDescribe.Leaping,
            Resources.PotionDescribe.Luck,
            Resources.PotionDescribe.Mundane_Potion,
            Resources.PotionDescribe.Night_Vision,
            Resources.PotionDescribe.Poison,
            Resources.PotionDescribe.Regeneration,
            Resources.PotionDescribe.Slowness,
            Resources.PotionDescribe.Strength,
            Resources.PotionDescribe.Swiftness,
            Resources.PotionDescribe.Thick_Potion,
            Resources.PotionDescribe.Water_Bottle,
            Resources.PotionDescribe.Water_Breathing,
            Resources.PotionDescribe.Weakness,
            Resources.PotionDescribe.Harming_II,
            Resources.PotionDescribe.Instant_Health_II,
            Resources.PotionDescribe.Leaping_II,
            Resources.PotionDescribe.Poison_II,
            Resources.PotionDescribe.Regeneration_II,
            Resources.PotionDescribe.Strength_II,
            Resources.PotionDescribe.Swiftness_II,
            Resources.PotionDescribe.Long_Fire_Resistance,
            Resources.PotionDescribe.Long_Invisibility,
            Resources.PotionDescribe.Long_Leaping,
            Resources.PotionDescribe.Long_Night_Vision,
            Resources.PotionDescribe.Long_Poison,
            Resources.PotionDescribe.Long_Regeneration,
            Resources.PotionDescribe.Long_Slowness,
            Resources.PotionDescribe.Long_Strength,
            Resources.PotionDescribe.Long_Swiftness,
            Resources.PotionDescribe.Long_Water_Breathing,
            Resources.PotionDescribe.Long_Weakness,
        };
        /// <summary>
        ///  获取单个Potion及其描述
        /// </summary>
        /// <param name="i">Potion序号</param>
        /// <returns></returns>
        public string[] GetPotion(int i)
        {
            if (i < 0 || i > (Potion.Count() - 1))
            {
                string[] r = { "Count Error!", null };
                return r;
            }
            else
            {
                string[] r = { Potion[i], PotionDescribe[i] };
                return r;
            }
        }
        /// <summary>
        /// 获取Potion数量
        /// </summary>
        /// <returns></returns>
        public int GetPotionCount() { return Potion.Count(); }
    }
}
