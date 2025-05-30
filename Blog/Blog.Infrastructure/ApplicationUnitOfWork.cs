﻿using Blog.Domain;
using Blog.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork , IApplicationUnitOfWork
    {
        public ApplicationUnitOfWork(ApplicationDbContext context, IBookRepository bookRepository, 
            IAuthorRepository authorRepository) : base(context)
        {
            BookRepository = bookRepository;
            AuthorRepository = authorRepository;
        }

        public IBookRepository BookRepository { get; private set; }

        public IAuthorRepository AuthorRepository { get; private set; }
    }
}
