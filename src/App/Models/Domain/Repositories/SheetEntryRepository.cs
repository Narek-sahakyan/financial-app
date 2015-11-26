﻿namespace App.Models.Domain.Repositories {
    using System;
    using System.Data.SqlClient;
    using Microsoft.Data.Entity;

    partial class SheetEntryRepository {
        public void ReplaceSortOrder(Sheet sheet, int oldSortOrder, int newSortOrder) {
            this._dbContext.Database.ExecuteSqlCommand(
                "UPDATE SheetEntry SET SortOrder = @newSortOrder WHERE SortOrder = @oldSortOrder WHERE Sheet_Id = @sheetId",
                new SqlParameter("newSortOrder", newSortOrder),
                new SqlParameter("oldSortOrder", oldSortOrder),
                new SqlParameter("sheetId", sheet.Id));
        }
    }
}