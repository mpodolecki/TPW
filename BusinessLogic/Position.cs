//____________________________________________________________________________________________________________________________________
//
//  Copyright (C) 2024, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and get started commenting using the discussion panel at
//
//  https://github.com/mpostol/TP/discussions/182
//
//_____________________________________________________________________________________________________________________________________

namespace TP.ConcurrentProgramming.BusinessLogic
{
    public class Position : IPosition
    {
        #region IPosition
        public double x { get; init; }
        public double y { get; init; }
        #endregion IPosition

        public Position(double XComponent, double YComponent)
        {
            x = XComponent;
            y = YComponent;
        }
    }
}