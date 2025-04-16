//__
//
//  Copyright (C) 2024, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the Watch button and get started commenting using the discussion panel at
//
//  https://github.com/mpostol/TP/discussions/182
//
//_

namespace TP.ConcurrentProgramming.Data
{
    internal class Ball : IBall
    {
        #region ctor

        internal Ball(Vector initialPosition, Vector initialVelocity)
        {
            Position = initialPosition;
            Velocity = initialVelocity;
        }

        #endregion ctor

        #region IBall

        public event EventHandler<IVector>? NewPositionNotification;
        public IVector Velocity { get; set; }

        #endregion IBall

        #region private

        private const double MaxX = 372;
        private const double MaxY = 392;
        private Vector Position;

        private void RaiseNewPositionChangeNotification()
        {
            NewPositionNotification?.Invoke(this, Position);
        }

        internal void Move()
        {
            // Aktualizacja pozycji
            Position = new Vector(
              Position.x + Velocity.x,
              Position.y + Velocity.y
            );

            // Odbicie od lewej/prawej ściany
            if (Position.x <= 0 || Position.x >= MaxX) 
                Velocity = new Vector(-Velocity.x, Velocity.y);

            // Odbicie od górnej/dolnej ściany
            if (Position.y <= 0 || Position.y >= MaxY) 
                Velocity = new Vector(Velocity.x, -Velocity.y);

            RaiseNewPositionChangeNotification();
        }

        #endregion private
    }
}
