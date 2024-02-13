﻿using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Interfaces_EntityFramework
{
    public interface IEmailAddressServiceEf
    {
        Task<List<EmailAddressModel>> GetEmailAddressesListEfAsync();
        Task<EmailAddressModel> GetEmailAddressByIdEfAsync(int id);
        Task<EmailAddressModel> CreateEmailAddressEfAsync(EmailAddressModel emailAddress);
        Task<EmailAddressModel> CreateEmailAddressByLeaseholderIdEfAsync(EmailAddressModel emailAddress, int leaseholderId);
        Task UpdateEmailAddressEfAsync(EmailAddressModel emailAddress);
        Task DeleteEmailAddressEfAsync(EmailAddressModel emailAddress);
    }
}