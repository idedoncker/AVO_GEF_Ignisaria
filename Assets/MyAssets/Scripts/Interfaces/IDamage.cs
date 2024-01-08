public interface IDamage
{
    public int hitPoints { get; set; }

    public void DoDamage(int damage) { }

    private void Kill() { }
}
