using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using FluentValidation;

namespace Business.Validation
{
    public class CrewValidator : AbstractValidator<Crew>
    {
        public CrewValidator()
        {
            // ekipBaslik (başlık) için kural (boş olmamalı ve uzunluk kontrolü)
            RuleFor(x => x.ekipBaslik)
                .NotEmpty().WithMessage("Ekip Başlık alanı boş geçilemez.")
                .Length(5, 150).WithMessage("Ekip Başlık, 5 ile 150 karakter arasında olmalıdır.");

            // ekipDetay (detay açıklama) için kural (boş olmamalı ve uzunluk kontrolü)
            RuleFor(x => x.ekipDetay)
                .NotEmpty().WithMessage("Ekip Detay alanı boş geçilemez.")
                .Length(20, 500).WithMessage("Ekip Detay, 20 ile 500 karakter arasında olmalıdır.");

            // ekipFoto (fotoğraf URL'si) için kural (boş olmamalı ve geçerli bir URL olmalı)
            RuleFor(x => x.ekipFoto)
                .NotEmpty().WithMessage("Ekip Fotoğraf alanı boş geçilemez.")
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").WithMessage("Geçerli bir fotoğraf URL'si girin.");
        }
    }
}
