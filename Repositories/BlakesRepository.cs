




namespace blakeslist.Repositories
{
    public class BlakesRepository
    {

        private readonly IDbConnection _db;

        public BlakesRepository(IDbConnection db)
        {
            _db = db;
        }


        internal List<Blake> GetBlakes()
        {
            string sql = "SELECT * FROM blakes;";
            List<Blake> blakes = _db.Query<Blake>(sql).ToList();
            return blakes;
        }


        internal Blake GetBlakeById(int blakeId)
        {
            string sql = "SELECT * FROM blakes WHERE id = @blakeId;";

            Blake blake = _db.Query<Blake>(sql, new { blakeId }).FirstOrDefault();
            return blake;
        }

        internal Blake CreateBlake(Blake blakeData)
        {
            string sql = @"
            INSERT INTO blakes (name, favoriteMovie, age, year, isBlake, isFlexible)
            VALUES (@Name, @FavoriteMovie, @Age, @Year, @IsBlake, @IsFlexible);
            SELECT * FROM blakes WHERE id = LAST_INSERT_ID();";

            Blake blake = _db.Query<Blake>(sql, blakeData).FirstOrDefault();
            return blake;
        }

        internal void DestroyBlake(int blakeId)
        {
            string sql = "DELETE FROM blakes WHERE id = @blakeId LIMIT 1;";
            _db.Execute(sql, new { blakeId });
        }

        internal void UpdateBlake(Blake originalBlake)
        {
            string sql = @"
            UPDATE blakes
            SET
            name = @Name,
            favoriteMovie = @FavoriteMovie,
            age = @Age,
            isBlake = @isBlake,
            isFlexible = @IsFlexible
            WHERE id = @Id;";

            _db.Execute(sql, originalBlake);
        }
    }
}