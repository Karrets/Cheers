namespace Cheers;

public static class CountryManager {
    public static List<string> CountryList => DataList.Select(data => data.Name).ToList();

    public static List<(string Name, int LegalAge)> DataList { get; } = [
        ("Unknown", 21),
        ("Central African Republic", 15),
        ("Mali", 15),
        ("Antigua", 16),
        ("Austria", 16),
        ("Barbados", 16),
        ("Belgium", 16),
        ("Burundi", 16),
        ("Chad", 16),
        ("Cuba", 16),
        ("Denmark", 16),
        ("Dominica", 16),
        ("Georgia", 16),
        ("Germany", 16),
        ("Haiti", 16),
        ("Luxembourg", 16),
        ("Palestine", 16),
        ("Saint Lucia", 16),
        ("San Marino", 16),
        ("Suriname", 16),
        ("Switzerland", 16),
        ("Malta", 17),
        ("Albania", 18),
        ("Algeria", 18),
        ("Angola", 18),
        ("Argentina", 18),
        ("Armenia", 18),
        ("Australia", 18),
        ("Azerbaijan", 18),
        ("Bahamas", 18),
        ("Bangladesh", 18),
        ("Belarus", 18),
        ("Belize", 18),
        ("Bhutan", 18),
        ("Bolivia", 18),
        ("Bosnia", 18),
        ("Botswana", 18),
        ("Brazil", 18),
        ("Bulgaria", 18),
        ("Cabo Verde", 18),
        ("Chile", 18),
        ("China", 18),
        ("Colombia", 18),
        ("Comoros", 18),
        ("Cook Islands", 18),
        ("Costa Rica", 18),
        ("Cote d’Ivoire", 18),
        ("Croatia", 18),
        ("Cyprus", 18),
        ("Czech Republic", 18),
        ("Democratic Republic of Congo", 18),
        ("Dominican Republic", 18),
        ("El Salvador", 18),
        ("Ecuador", 18),
        ("Equatorial New Guinea", 18),
        ("Estonia", 18),
        ("Eswatini", 18),
        ("Ethiopia", 18),
        ("Fiji", 18),
        ("Finland", 18),
        ("France", 18),
        ("Gabon", 18),
        ("Gambia", 18),
        ("Ghana", 18),
        ("Greece", 18),
        ("Grenada", 18),
        ("Guatemala", 18),
        ("Guinea", 18),
        ("Guyana", 18),
        ("Honduras", 18),
        ("Hong Kong", 18),
        ("Hungary", 18),
        ("Ireland", 18),
        ("Israel", 18),
        ("Italy", 18),
        ("Jamaica", 18),
        ("Jordan", 18),
        ("Kenya", 18),
        ("Kyrgyzstan", 18),
        ("Lao People’s Democratic Republic", 18),
        ("Latvia", 18),
        ("Lebanon", 18),
        ("Liberia", 18),
        ("Lithuania", 18),
        ("Macedonia", 18),
        ("Madagascar", 18),
        ("Malawi", 18),
        ("Malaysia", 18),
        ("Mauritius", 18),
        ("Mexico", 18),
        ("Moldova", 18),
        ("Monaco", 18),
        ("Mongolia", 18),
        ("Montenegro", 18),
        ("Morocco", 18),
        ("Mozambique", 18),
        ("Myanmar", 18),
        ("Namibia", 18),
        ("Nepal", 18),
        ("Netherlands", 18),
        ("New Zealand", 18),
        ("Nicaragua", 18),
        ("Niger", 18),
        ("Nigeria", 18),
        ("Niue", 18),
        ("North Korea", 18),
        ("Norway", 18),
        ("Panama", 18),
        ("Papua New Guinea", 18),
        ("Peru", 18),
        ("Philippines", 18),
        ("Poland", 18),
        ("Portugal", 18),
        ("Republic of Congo", 18),
        ("Puerto Rico", 18),
        ("Romania", 18),
        ("Russia", 18),
        ("Rwanda", 18),
        ("Saint Kitts and Nevis", 18),
        ("Saint Vincent and the Grenadines", 18),
        ("Sao Tome and Principe", 18),
        ("Senegal", 18),
        ("Serbia", 18),
        ("Seychelles", 18),
        ("Sierra Leone", 18),
        ("Singapore", 18),
        ("Slovakia", 18),
        ("Slovenia", 18),
        ("South Africa", 18),
        ("South Sudan", 18),
        ("Spain", 18),
        ("Sweden", 18),
        ("Syria", 18),
        ("Taiwan", 18),
        ("Tajikistan", 18),
        ("Tanzania", 18),
        ("Tongo", 18),
        ("Trinidad and Tobago", 18),
        ("Tunisia", 18),
        ("Turkey", 18),
        ("Turkmenistan", 18),
        ("Tuvalu", 18),
        ("Uganda", 18),
        ("UK", 18),
        ("Ukraine", 18),
        ("Uruguay", 18),
        ("Venezuela", 18),
        ("Vietnam", 18),
        ("Zambia", 18),
        ("Zimbabwe", 18),
        ("Qatar", 19),
        ("South Korea", 19),
        ("Canada", 19),
        ("United Arab Emirates", 21),
        ("India", 21),
        ("Benin", 20),
        ("Iceland", 20),
        ("Japan", 20),
        ("Paraguay", 20),
        ("Thailand", 20),
        ("Uzbekistan", 20),
        ("Bahrain", 21),
        ("Cambodia", 21),
        ("Cameroon", 21),
        ("Egypt", 21),
        ("Indonesia", 21),
        ("Iraq", 21),
        ("Kazakhstan", 21),
        ("Kiribati", 21),
        ("Lesotho", 21),
        ("Marshall Islands", 21),
        ("Mauritania", 21),
        ("Micronesia", 21),
        ("Nauru", 21),
        ("Oman", 21),
        ("Palau", 21),
        ("Samoa", 21),
        ("Solomon Islands", 21),
        ("Sri Lanka", 21),
        ("USA", 21),
        ("United States", 21),
        ("Eritrea", 25),
        ("Afghanistan", -1),
        ("Brunei", -1),
        ("Iran", -1),
        ("Kuwait", -1),
        ("Libya", -1),
        ("Maldives", -1),
        ("Pakistan", -1),
        ("Saudi Arabia", -1),
        ("Somalia", -1),
        ("Sudan", -1),
        ("Yemen", -1),
        ("Burkina Faso", 0),
        ("Djibouti", 0),
        ("Guinea-Bissau", 0),
        ("Timor-Leste", 0),
        ("Togo", 0),
        ("Vanuatu", 0),
        ("Western Sahara", 0)
    ];
}