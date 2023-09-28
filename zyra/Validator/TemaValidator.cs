using FluentValidation;
using zyra.Model;

namespace zyra.Validator
{
    public class TemaValidator : AbstractValidator<Tema>
    {
        public TemaValidator()
        {
            RuleFor(n => n.Nome)
              .NotEmpty()
              .MinimumLength(5)
              .MaximumLength(255);

            RuleFor(d => d.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
        }
    }
}
