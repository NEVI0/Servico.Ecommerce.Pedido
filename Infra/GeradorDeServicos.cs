﻿using Microsoft.Extensions.Caching.Memory;

namespace Ecommerce.Pedido
{
    public static class GeradorDeServicos
    {
        public static ServiceProvider ServiceProvider;

        public static DataContext CarregarContexto()
        {
            return ServiceProvider.GetService<DataContext>();
        }

        public static IMemoryCache CarregarServicoDeCache()
        {
            return ServiceProvider.GetService<IMemoryCache>();
        }
    }
}
