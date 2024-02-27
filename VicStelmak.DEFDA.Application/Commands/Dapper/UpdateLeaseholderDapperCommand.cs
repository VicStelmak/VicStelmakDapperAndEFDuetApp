﻿using MediatR;
using VicStelmak.DEFDA.Application.Requests;

namespace VicStelmak.DEFDA.Application.Commands.Dapper
{
    public record UpdateLeaseholderDapperCommand(int leaseholderId, UpdateLeaseholderRequest leaseholderUpdatingRequest) : IRequest;
}
