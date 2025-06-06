﻿using MediatR;
using Note.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Application.Features.Books.Commands
{
    public class BookAddCommand : IRequest
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}
