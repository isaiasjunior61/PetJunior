using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetJunior.Models;

namespace PetJunior.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Claudio Ptolomeu", "011.022.033.44", "matematico@sp.senai.br", "Lopeu");
        Cliente cliente2 = new Cliente(02, "Charles Darwin", "022.033.044.55", "biologo@sp.senai.br", "Tutuco");
        Cliente cliente3 = new Cliente(03, "Pitágoras de Samos", "044.055.066.77", "filosofo@sp.senai.br", "Samuca");
        Cliente cliente4 = new Cliente(04, "Parmênidis de Eleia", "055.066.077.88", "pamenidis@sp.senai.br", "Spike");
        Cliente cliente5 = new Cliente(05, "Martinho Lutero", "066.077.088.99", "martin@sp.senai.br", "Martin");

        List<Cliente> listaClientes = new List <Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Amazon Pets LTDA", "24.989.321/0023-80", "apts@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "SpaceEx", "30.565.002/9977-05", "gatodoespaco@spce.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Tesla Cães & Gatos", "64.989.321/6578-33", "atenidmento.tsla@tsla.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Naza Bixos Escrotos", "98.655.321/3023-60", "titans@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Rações Cisco", "65.666.321/9984-10", "sac.racoes@cisco.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
