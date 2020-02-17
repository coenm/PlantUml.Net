﻿using System;
using System.Threading.Tasks;

namespace PlantUml.Net
{
    public interface IPlantUmlRenderer
    {
        Task<byte[]> Render(string code, OutputFormat outputFormat);

        Uri RenderAsUri(string code, OutputFormat outputFormat);
    }
}