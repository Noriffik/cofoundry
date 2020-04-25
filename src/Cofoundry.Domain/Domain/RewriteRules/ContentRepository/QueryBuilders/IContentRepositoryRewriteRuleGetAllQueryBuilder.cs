﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Domain
{
    /// <summary>
    /// Queries to search for user data, returning paged lists of data.
    /// </summary>
    public interface IContentRepositoryRewriteRuleGetAllQueryBuilder
    {
        /// <summary>
        /// The RewriteRuleSummary projection is small and designed to be cacheable.
        /// This result set is cached by default and is quick to access.
        /// </summary>
        Task<ICollection<RewriteRuleSummary>> AsSummariesAsync();
    }
}