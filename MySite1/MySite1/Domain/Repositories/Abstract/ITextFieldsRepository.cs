using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySite1.Domain.Entities;

namespace MySite1.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
