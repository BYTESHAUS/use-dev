﻿namespace AbcExt.Errors.Data;

public class EntityNotFound(string message)
    : Exception<EntityNotFound>(message);
