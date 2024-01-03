﻿using ProjetoUdemy.Data;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Services
{
    public class SellerService
    {
        private readonly ProjetoUdemyContext _context;

        public SellerService(ProjetoUdemyContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
