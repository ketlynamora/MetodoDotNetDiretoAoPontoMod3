﻿namespace DevFreela.Application.InputModels
{
    public class NewProjectInputModel
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }

    }
}
