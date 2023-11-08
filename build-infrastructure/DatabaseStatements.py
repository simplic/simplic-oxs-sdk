def insert_version_number(connection, cursor, productname, new_version_number):
    if(connection == None or cursor == None):
        return
    try:
        cursor.execute("Select a.productid from ESS_MS_Intern_Dev_Products_Version a "
                                + "join ESS_MS_Intern_Dev_Products b on a.productid = b.ident "
                                + f"where b.productname = '{productname}' group by a.productid")
        productid = cursor.fetchone()[0]
        cursor.execute(f"Select major, minor, build, revision from ESS_MS_Intern_Dev_Products_Version where productid = {productid} order by major desc, minor desc, build desc, revision desc")
        current_number = cursor.fetchone()

        if current_number.major == current_number.minor == current_number.build == current_number.revision == 9:
            cursor.execute('Update ESS_MS_Intern_Dev_Products_Version ' +
            f'set major = {new_version_number[0]}, minor = {new_version_number[1]}, build = {new_version_number[2]}, revision = {new_version_number[3]} ' +
            f'where productid = {productid} and major = 9 and minor = 9 and build = 9 and revision = 9')
            print(f'Updated version number  {new_version_number} in database. Set all (9, 9, 9, 9) versions to new version.')
        else:
            cursor.execute("Insert into ESS_MS_Intern_Dev_Products_Version (productid, major, minor, build, revision) values "
                        f"({productid}, {new_version_number[0]}, {new_version_number[1]}, {new_version_number[2]}, {new_version_number[3]})")
            print(f'Inserted version number {new_version_number} in database.')
        connection.commit()
    except:
        pass