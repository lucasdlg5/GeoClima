Console.WriteLine("Hello, World!");

// Latitude 23 sul e 45 Oeste -- São Jose dos Campos - São Paulo
// 35 Norte e 139 Leste - Japão - Tokyo
// 57 Norte e 65 Leste - Tyumen - Sibéria - Russia

Dictionary<string, string> dados = new Dictionary<string, string>();
dados.Add("Sao Jose dos Campos", "23 sul e 45 Oeste");
dados.Add("Tokyo", "35 Norte e 139 Leste");
dados.Add("Tyumen", "57 Norte e 65 Leste");



//string[] list = { "Sao Jose dos Campos", "Tokyo", "Tyumen" };
//string[] coordenadas = { "23 sul e 45 Oeste" , "35 Norte e 139 Leste", "57 Norte e 65 Leste" };

string buscaCidadeLatitudeLongitude(string latitude, string longitude)
{

    return "";
}

string buscaPorNome(string cidade)
{
    //for (int i = 0; i < cidade.Count(); i++)
    //{
    //    if (list[i].Equals(cidade))
    //    {
    //        return $"{list[i]} - {coordenadas[i]}";
    //    }
    //}

    foreach (var item in dados)
    {
        if (item.Key.Equals(cidade))
        {
            return $"{item.Key} - {item.Value}";
        }
    }
    return "N/A";
}

Console.WriteLine(buscaPorNome("Sao Jose dos Campos")); // Sao jose dos campos
Console.WriteLine(buscaPorNome("Sao")); // Nao ha cidade disponivel
Console.WriteLine(buscaPorNome("")); // Nao ha cidade disponivel
Console.WriteLine(buscaPorNome("Tyumen")); // Tyumen
Console.WriteLine(buscaPorNome("Tokyo")); // Tokyo