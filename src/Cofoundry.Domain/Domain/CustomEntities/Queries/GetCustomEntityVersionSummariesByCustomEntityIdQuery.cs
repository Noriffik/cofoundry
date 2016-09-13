﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofoundry.Domain.CQS;

namespace Cofoundry.Domain
{
    public class GetCustomEntityVersionSummariesByCustomEntityIdQuery : IQuery<IEnumerable<CustomEntityVersionSummary>>
    {
        public int CustomEntityId { get; set; }
    }
}