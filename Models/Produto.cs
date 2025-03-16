﻿using SQLite;

namespace Compras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement ]
        public int Id { get; set; }
        public string Desvricao { get; set; }

        public double Quantidade { get; set; }

        public double Preco {  get; set; }


        }
}
