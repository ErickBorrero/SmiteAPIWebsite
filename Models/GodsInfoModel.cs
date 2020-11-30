using System;

namespace SmiteAPIWebsite
{

    public class Gods
    {
        public string Ability1 { get; set; }
        public string Ability2 { get; set; }
        public string Ability3 { get; set; }
        public string Ability4 { get; set; }
        public string Ability5 { get; set; }
        public int AbilityId1 { get; set; }
        public int AbilityId2 { get; set; }
        public int AbilityId3 { get; set; }
        public int AbilityId4 { get; set; }
        public int AbilityId5 { get; set; }
        public Ability Ability_1 { get; set; }
        public Ability Ability_2 { get; set; }
        public Ability Ability_3 { get; set; }
        public Ability Ability_4 { get; set; }
        public Ability Ability_5 { get; set; }
        public float AttackSpeed { get; set; }
        public float AttackSpeedPerLevel { get; set; }
        public string AutoBanned { get; set; }
        public string Cons { get; set; }
        public float HP5PerLevel { get; set; }
        public int Health { get; set; }
        public int HealthPerFive { get; set; }
        public int HealthPerLevel { get; set; }
        public string Lore { get; set; }
        public float MP5PerLevel { get; set; }
        public int MagicProtection { get; set; }
        public float MagicProtectionPerLevel { get; set; }
        public int MagicalPower { get; set; }
        public float MagicalPowerPerLevel { get; set; }
        public int Mana { get; set; }
        public float ManaPerFive { get; set; }
        public int ManaPerLevel { get; set; }
        public string Name { get; set; }
        public string OnFreeRotation { get; set; }
        public string Pantheon { get; set; }
        public int PhysicalPower { get; set; }
        public object PhysicalPowerPerLevel { get; set; }
        public int PhysicalProtection { get; set; }
        public float PhysicalProtectionPerLevel { get; set; }
        public string Pros { get; set; }
        public string Roles { get; set; }
        public int Speed { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public Abilitydescription abilityDescription1 { get; set; }
        public Abilitydescription abilityDescription2 { get; set; }
        public Abilitydescription abilityDescription3 { get; set; }
        public Abilitydescription abilityDescription4 { get; set; }
        public Abilitydescription abilityDescription5 { get; set; }
        public Basicattack basicAttack { get; set; }
        public string godAbility1_URL { get; set; }
        public string godAbility2_URL { get; set; }
        public string godAbility3_URL { get; set; }
        public string godAbility4_URL { get; set; }
        public string godAbility5_URL { get; set; }
        public string godCard_URL { get; set; }
        public string godIcon_URL { get; set; }
        public int id { get; set; }
        public string latestGod { get; set; }
        public object ret_msg { get; set; }
    }

    public class Ability
    {
        public Description Description { get; set; }
        public int Id { get; set; }
        public string Summary { get; set; }
        public string URL { get; set; }
    }

    public class Description
    {
        public Textdescription itemDescription { get; set; }
    }

    public class Textdescription
    {
        public string cooldown { get; set; }
        public string cost { get; set; }
        public string description { get; set; }
        public Menuitem[] menuitems { get; set; }
        public Rankitem[] rankitems { get; set; }
    }

    public class Menuitem
    {
        public string description { get; set; }
        public string value { get; set; }
    }

    public class Rankitem
    {
        public string description { get; set; }
        public string value { get; set; }
    }


    public class Abilitydescription
    {
        public Textdescription itemDescription { get; set; }
    }

    public class Basicattack
    {
        public Textdescription itemDescription { get; set; }
    }
}