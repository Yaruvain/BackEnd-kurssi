using System;

namespace ass1 {
    public class NotFoundExeption : Exception {
        public NotFoundExeption () : base ("Station not found. ") {

        }
    }
}