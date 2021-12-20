﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.Fhir.Synapse.DataSource.Fhir
{
    public interface IFhirSpecificationProvider
    {
        public IEnumerable<string> GetAllResourceTypes();

        public bool IsValidFhirResourceType(string resourceType);
    }
}