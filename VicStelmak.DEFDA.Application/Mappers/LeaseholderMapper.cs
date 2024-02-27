﻿using VicStelmak.DEFDA.Application.Requests;
using VicStelmak.DEFDA.Application.Responses;
using VicStelmak.DEFDA.Domain.Models;

namespace VicStelmak.DEFDA.Application.Mappers
{
    public static class LeaseholderMapper
    {
        internal static LeaseholderModel MapToLeaseholder(this CreateLeaseholderRequest leaseholderCreatingRequest)
        {
            return new LeaseholderModel()
            {
                FirstName = leaseholderCreatingRequest.FirstName,
                LastName = leaseholderCreatingRequest.LastName
            };
        }

        public static LeaseholderModel MapToLeaseholder(this UpdateLeaseholderRequest leaseholderUpdatingRequest)
        {
            return new LeaseholderModel()
            {
                FirstName = leaseholderUpdatingRequest.FirstName,
                LastName = leaseholderUpdatingRequest.LastName
            };
        }

        public static LeaseholderResponse MapToLeaseholderResponse(this LeaseholderModel leaseholder)
        {
            return new LeaseholderResponse(leaseholder.Id, leaseholder.FirstName, leaseholder.LastName);
        }
    }
}
