namespace RoleplayGame

{
    public interface ICharacter
    {
        public string Name {get; set;}
        public int QuantityLife {get; set;}

        public void AttackWeapon(ICharacter objetivo);
        

        public void Cure (int quantity);


    }

}