﻿using Microsoft.EntityFrameworkCore;
using Note.Domain;
using Note.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork , IApplicationUnitOfWork
    {
        public IBookRepository BookRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }
        public ApplicationUnitOfWork(ApplicationDbContext context, IBookRepository bookRepository,
            IAuthorRepository authorRepository) 
            : base(context)
        {
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
        }
    }
}
