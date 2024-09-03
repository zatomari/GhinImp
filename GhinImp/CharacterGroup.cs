namespace GhinImp;

// Класс для управления группой персонажей
public class CharacterGroup
{
    private List<Character> characters;

    public List<Character> Characters => characters;

    public CharacterGroup()
    {
        characters = new List<Character>();
    }

    // Метод для добавления персонажей
    public void AddCharacter(string name, string element, int attackPower, params Skill[] skills)
    {
        var character = new Character(name, element, attackPower, skills.ToList());
        characters.Add(character);

    }

    // Метод для фильтрации персонажей по критерию
    public IEnumerable<Character> FilterCharacters(Func<Character, bool> criteria)
    {
        return characters.Where(x => criteria(x));
    }

    // Метод для сортировки персонажей по имени
    public IEnumerable<Character> SortCharactersByName()
    {
        return characters.OrderByDescending(c => c.Name);
    }

    // Метод для подсчета количества персонажей определенного элемента
    public int CountCharactersByElement(string element)
    {
        return characters.Count(c => c.Element == element);
    }

    // Метод для получения персонажа с наибольшей атакой
    public Character GetStrongestCharacter()
    {
        return characters.MaxBy(c => c.AttackPower);
    }

    // Метод для поиска персонажа по имени
    public string FindCharacterByName(string name)
    {
        return characters.FirstOrDefault(c => c.Name == name).ToString();
    }
}