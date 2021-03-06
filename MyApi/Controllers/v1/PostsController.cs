﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MyApi.Models;
using Data.Contracts;
using Entities.Post;
using Microsoft.AspNetCore.Mvc;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    [ApiVersion("1")]
    public class PostsController : CrudController<PostDto, PostSelectDto, Post>
    {
        public PostsController(IRepository<Post> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

        public override Task<ActionResult<List<PostSelectDto>>> Get(CancellationToken cancellationToken)
        {
            return base.Get(cancellationToken);
        }
    }
}
