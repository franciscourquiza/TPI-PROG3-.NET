﻿using System.ComponentModel.DataAnnotations;

namespace e_commerce_API.Models
{
    public class EditClientDto
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo debe contener solo letras.")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "El campo debe contener solo letras.")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^\\d{10}$", ErrorMessage = "El numero debe estar compuesto por 10 cifras.")]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "El campo no debe contener símbolos ni caracteres especiales.")]
        public string State { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "El campo no debe contener símbolos ni caracteres especiales.")]
        public string City { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "El campo no debe contener símbolos ni caracteres especiales.")]
        public string Adress { get; set; }

        [Required]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "El campo DNI debe contener 8 dígitos.")]
        public int Dni { get; set; }
    }
}
