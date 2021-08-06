using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CadastroCliente2
{
    public class Util
    {
        public static List<SelectListItem> Estados = new List<SelectListItem>
        {
             new SelectListItem { Value="AC", Text = "Acre"},
             new SelectListItem { Value="AL", Text = "Alagoas"},
             new SelectListItem { Value="AP", Text = "Amapá"},
             new SelectListItem { Value="AM", Text = "Amazonas"},
             new SelectListItem { Value="BA", Text = "Bahia"},
             new SelectListItem { Value="CE", Text = "Ceará"},
             new SelectListItem { Value="DF", Text = "Distrito Federal"},
             new SelectListItem { Value="ES", Text = "Espírito Santo"},
             new SelectListItem { Value="GO", Text = "Goiás"},
             new SelectListItem { Value="MA", Text = "Maranhão"},
             new SelectListItem { Value="MT", Text = "Mato Grosso"},
             new SelectListItem { Value="MS", Text = "Mato Grosso do Sul"},
             new SelectListItem { Value="MG", Text = "Minas Gerais"},
             new SelectListItem { Value="PA", Text = "Pará"},
             new SelectListItem { Value="PB", Text = "Paraíba"},
             new SelectListItem { Value="PR", Text = "Paraná"},
             new SelectListItem { Value="PE", Text = "Pernambuco"},
             new SelectListItem { Value="PI", Text = "Piauí"},
             new SelectListItem { Value="RJ", Text = "Rio de Janeiro"},
             new SelectListItem { Value="RN", Text = "Rio Grande do Norte"},
             new SelectListItem { Value="RS", Text = "Rio Grande do Sul"},
             new SelectListItem { Value="RO", Text = "Rondônia"},
             new SelectListItem { Value="RR", Text = "Roraima"},
             new SelectListItem { Value="SC", Text = "Santa Catarina"},
             new SelectListItem { Value="SP", Text = "São Paulo"},
             new SelectListItem { Value="SE", Text = "Sergipe"},
             new SelectListItem { Value="TO", Text = "Tocantins"}
        };
    }
}
