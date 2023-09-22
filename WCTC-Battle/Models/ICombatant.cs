namespace WCTC_Battle.Models
{
    public interface ICombatant
    {
        void Attack(Enemy enemy);
        void EquipWeapon(IWeapon weapon);
    }
}