using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppSettings.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    //↓↓↓追加
    private readonly IConfiguration _configuration;

    public String SampleValue { get; set; }
    //↑↑↑追加

    //↓↓↓引数追加
    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
    //↑↑上引数追加
        _logger = logger;
        //↓↓↓追加
        _configuration = configuration;
        //↑↑↑追加
    }

    public void OnGet()
    {
        //↓↓↓追加
        SampleValue = _configuration["sampleKey"];
        //↑↑↑追加
    }
}

