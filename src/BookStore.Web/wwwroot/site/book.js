$(function () {
    var localizer = abp.localization.getResource('BookStore');

    var dataTable = $('#books-table').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(bookStore.services.book.book.getList),
            columnDefs: [
                {
                    title: localizer('Name'),
                    data: "name"
                },
                {
                    title: localizer('Type'),
                    data: "type",
                    render: function (data) {
                        return localizer('Enum:BookType:' + data);
                    }
                },
                {
                    title: localizer('PublishedDate'),
                    data: "publishedDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
                {
                    title: localizer('Price'),
                    data: "price"
                }
            ]
        })
    );
});