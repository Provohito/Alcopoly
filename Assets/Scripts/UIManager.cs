using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;





public class UIManager : MonoBehaviour
{
    

    [HideInInspector]
    public List<string> namePlayer = new List<string>();
    [SerializeField]
    private Image fillground;
    private string _nameUI;

    
    public string nameUI
    {
        get {return _nameUI;}
        set { _nameUI = value;}
    }
    [HideInInspector]
    public string simpleVariable;
    //блок выбора темы
    [HideInInspector]
    public List<string> questions = new List<string>();
    //string path = @"D:\Work\Alcopoly\Assets\Resources\";
    string nameTheme;
    List<string> theme1 = new List<string>() {
        "{Player}, кто из пресудствующих самый сексуальный(ная)? Тот пьет 3 раза!",
        "{Player}, сними 1 элемент одежды и выпей 1 раз или пей до дна!",
        "Перечисяем нижнее бельё, кто первый затупит тот пьет 3 раза! {Player}, начинает.",
        "{Player}, тебя дальше должны называть Госпожа(Господин), кто забудет пьет 4 раза!",
        "Девушки трогают парней за выбранное место 4 секунды, если парень откажеться пьет 4 рза!",
        "Теперь парни наливают девушкам, что хотят!",
        "{Player}, должен угадать всех закрытыми глазами на ощупь! За каждую не угадонную попытку пьет 3 раза!",
        "Те, кто хоть раз флиртовал только ради халявных напитков, пьют 5 раз.",
        "Кому нравился их преподователь в сексуальном плане пьет 6 раз!",
        "Девушки кого из компании вы бы предпочли? На кого упадет выбор пьют 7 раз!",
        "Тот, кому хоть раз приходилось брать отгул на работе из-за похмелья, пьет 2 раза.",
        "{Player}, танцуй тверк или пей до дна! ",
        "{Player}, выложи в историю что ты за радугу!",
        "{Player}, как относишься к сексу на первом свидании? Если неготивно пей 1 раз.",
        "{Player}, пользуешься секс-игрушками? Если нет пей 5 раз.",
        "{Player}, был секс в общественном месте? Если нет пей 5 раз.",
        "{Player}, если бы ты стал(а) невидимкой, за кем бы тебе хотелось понаблюдать? Если не за кем пей 3 раза.",
        "{Player}, твой сексуальный фетиш? Или пей 3 раза!",
        "Тебе бы хотелось сняться в порно? Какого жанра? У кого совпадут мнения пьет 5 раз.",
        "Самая сексуальная часть женского тела? У кого совпадут мнения пьет 4 раза.",
        "Перечесляем категории из порно! Кто затупит тот пьет 4 раза. {Player} начинает.",
        "{Player}, приходилось лишать кого-нибудь девственности? Если да пей 6 раз.",
        "Говори самое грязное порно, которое ты смотрел(а)! Или пей 4 раза.",
        "Девушки отшлепайте {Player}! Если он(она) откажется пьет до дна!",
        "{Player}, с кем из мультяшных персонажей ты бы занялся(ась) сексом? Если не хочешь то пей 3 раза.",
        "{Player}, ты врал(а) когда-нибудь о количестве своих сексуальных партнеров? Если да то пей 6 раз.",
        "{Player}, сделал(а) бы татуировку в интимном месте? И какую? Если нет пей 4 раза.",
        "{Player}, ради секса с кем из знаменитостей ты был(а) бы готов(а) на все? Если ни скем пей 3 раза.",
        "{Player}, назави самую сексуальную часть тела среди играков и назови его! Или пей 3 раза!",
        "У кого есть фетишь пьет 3 раза! А у кого его нет 5 раз!"
    };
    List<string> theme2 = new List<string>() {
        "Если у тебя етсь алергия пей 3 раза.",
        "{Player}, выпей 2 раза;",
        "{Player}, назови свой любимые диснеевские фильмы или мультики. Если твой выбор совпал с кем-то из компании, вместе пейте 5 раз.",
        "{Player}, назови свои понравившиеся сериалы . Если твой выбор совпал с кем-то из компании, вместе пейте 3 раз.",
        "Если ты не куришь пей 5 раза. За здоровье))",
        "{Player}, пей до дна!",
        "Все, кто в универе хоть раз отправляли на пересдачу, пьют до дна!",
        "Страны на букву D. Проигравший пьет 5 раз.",
        "Все, кто старше, чем {Player}, пьют 4 раза.",
        "{Player}, станцуй маленьких утят или выпей 4 раза.",
        "БургерКинг или Макдональс? Те, у кого меньше голосов, пьют 4 раза.",
        "Игроки, которые недавно смотрели один и тот же фильм, пьют 2 раза.",
        "Те, чье имя начинаеться на гласную пьют 4 раза.",
        "Кто легче 60 кг пьет 5 раз.",
        "{Player}, запости общую фотку Instagram или TikTok. Откажешься — пей до дна!",
        "Мужики! Все парни должны до пить до дна.",
        "У кого из игроков больше шансов умереть первым во время зомби-апокалипсиса? Победитель пьет 4 раза.",
        "Если ты красавчик пей 5 раз.",
        "{Player} должен рассказать самую стыдную историю, или пьет 5 раз!",
        "Кто за ЗОЖ тот за ЖИЗ пьет 3 раза!",
        "Рауд. Кто назавет меньшее кол-во РОК групп пьет 3 раза.",
        "{Player}, встань и наклонись НЕ згибая колени, если НЕ сможешь пей 3 раза.",
        "Если ты с средним специальным пей 5 раз!",
        "Если ты играешь со своей полавинкой то пей 3 раза вместе ней(им).",
        "{Player}, кого из пресудствующих хочешь побить? На кого пала эта судьба пьет 4 раза!",
        "{Player}, кто должен тебе? Кто должен пьет 3 раза!",
        "Кто считает что трезвый пьет 2 глотка!",
        "Кто смог бы пробежать марафон? На кого падет выбор большенства пьет за свое здоровье до дна!",
        "{Player}, скажи кто самый красивый по твоему мнению из компании? Красавчик(Красавица) пьет 6 раз!",
        "У кого было самое большое кол-во кличек? Тот пьет 3 раза!",
    };

    [SerializeField]
    private GameObject attentionWindowQuestions;

    List<string> firstListLoad = new List<string>();
    [SerializeField]
    public Text firstLoadText;

    [SerializeField]
    private GameObject attentionWindowTheme;

    [HideInInspector]
    public GameObject[] allThemes;

    [SerializeField]
    private GameObject chooseThemePanel;
    
    
    

    private void Start()
    {
        LoadFirstText();
        StartCoroutine(FirstLoad());
    }

    void Update()
    {

        if (_nameUI != null)
        {
            NextLevel(_nameUI);
        }

    }
    public void CheckFubction(string value)
    {
        if (namePlayer.Count != 0 & value == "chooseTheme")
        {
            nameUI = value;
            StopAllCoroutines();
            Debug.Log("questions");
        }
        else if (value == "chooseTheme")
        {
            StartCoroutine(AttentionPanel(attentionWindowQuestions));
        }
            

        if (questions.Count != 0 & value == "questionsPanel")
        {
            nameUI = value;
            StopAllCoroutines();
            Debug.Log("Theme");
        }
        else if (value == "questionsPanel")
        {
            StartCoroutine(AttentionPanel(attentionWindowTheme));
        }
            

    }

    IEnumerator AttentionPanel(GameObject activeObject)
    {
        activeObject.SetActive(true);
 
        yield return new WaitForSeconds(2f);

        activeObject.SetActive(false);
        StopAllCoroutines();
    }
    IEnumerator FirstLoad()
    {
        for (float ft = fillground.fillAmount; ft <= 1; ft += 0.0025f)
        {
            fillground.fillAmount += ft;
            yield return new WaitForSeconds(.1f);
            if(fillground.fillAmount == 1)
            {
                GameObject Namelevel = GameObject.Find("[Interface]/CanvasRoot/alertPanel");
                simpleVariable = Namelevel.name;
                
                Namelevel.SetActive(true);
                Namelevel = GameObject.Find("[Interface]/CanvasRoot/loadPanel");
                Namelevel.SetActive(false);
                StopAllCoroutines(); 
            }
        }
    }

    void NextLevel(string name)
    {
        
        GameObject Namelevel = GameObject.Find("[Interface]/CanvasRoot/" + simpleVariable);
        Namelevel.SetActive(false);
        Namelevel = GameObject.Find("[Interface]/CanvasRoot/"+ name );
        Namelevel.SetActive(true);
        simpleVariable = name;
        _nameUI = null;
    }
    
    public void SetValueStruct(string value)
    { 
        SaveName(value);
        
    }

    void SaveName(string value)
    {
        
        namePlayer.Add(value);
    }

    public void DeleteName(string value)
    {
        for (int i = 0; i < namePlayer.Count; i++)
        {
            if (namePlayer[i] == value)
            {
                namePlayer.Remove(value);
            }
        }
    }
    
    private void LoadFirstText()
    {
        firstListLoad.Add("Каждый день я покупаю водку. Я шопоголик?");
        firstListLoad.Add("Больше знаешь — крепче пьешь.");
        firstListLoad.Add("Поздно пить боржоми, когда уже коньяк купил.");
        firstListLoad.Add("Всех люблю на свете я — после литра вискаря!");
        firstListLoad.Add("Радости в жизни бывают невинные и винные.");
        firstLoadText.text = firstListLoad[UnityEngine.Random.Range(0, firstListLoad.Count)];
    }

    public void WriteText(string value)
    {
        nameTheme = value;
        
        if (value == "18+")
        {
            foreach (var item in theme1)
            {
                questions.Add(item);
            }
        }
        else
        {
            foreach (var item in theme2)
            {
                questions.Add(item);
            }
        }
        
    }

    public void wqe()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            Debug.Log(questions[i]);
        }
    }   
    public void ClearList()
    {
        questions.RemoveRange(0, questions.Count);
       
        
       
        chooseThemePanel.GetComponent<chooseThemeSrc>().isReset = true;
        
        
        
    }

    
}


