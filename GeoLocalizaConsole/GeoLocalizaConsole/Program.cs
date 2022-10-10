Console.WriteLine("Hello, World!");



// Latitude 23 sul e 45 Oeste -- São Jose dos Campos - São Paulo
// 35 Norte e 139 Leste - Japão - Tokyo
// 57 Norte e 65 Leste - Tyumen - Sibéria - Russia


string buscaCidadeLatitudeLongitude(string latitude, string longitude)
{

    return "";
}

Dictionary<string, string> dados = new Dictionary<string, string>();
dados.Add("Sao Jose dos Campos", "23 sul e 45 Oeste");
dados.Add("Tokyo", "35 Norte e 139 Leste");
dados.Add("Tyumen", "57 Norte e 65 Leste");

string buscaPorNome(string cidade)
{
    foreach (var item in dados)
    {
       if (item.Key.Equals("Sao Jose dos Campos")){
            return "Sao Jose dos Campos";
       }
       if (item.Key.Equals("Tokyo")){
            return "Tokyo";
       }
       if (item.Key.Equals("Tyumen"))
       {
            return "Tyumen";
       }
    }
    return "Nao ha cidade disponivel";
}



Console.WriteLine(buscaPorNome("Sao Jose dos Campos")); // Sao jose dos campos
Console.WriteLine(buscaPorNome("Sao")); // Nao ha cidade disponivel
Console.WriteLine(buscaPorNome("")); // Nao ha cidade disponivel
Console.WriteLine(buscaPorNome("Tyumen")); // Tyumen
Console.WriteLine(buscaPorNome("Tokyo")); // Tokyo