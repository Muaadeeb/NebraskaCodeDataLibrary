/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select * from dbo.Category)
Begin
    Insert Into dbo.Category(CategoryName)
	Values  ('Arts & Photography'),
            ('Biographies & Memoirs'),
            ('Business & Money'),
            ('Calendars'),
            ('Children''s Books'),
            ('Christian Books & Bibles'),
            ('Comics & Graphic Novels'),
            ('Computers & Technology'),
            ('Cookbooks, Food & Wine'),
            ('Crafts, Hobbies & Home'),
            ('Education & Teaching'),
            ('Engineering & Transportation'),
            ('Health, Fitness & Dieting'),
            ('History'),
            ('Humor & Entertainment'),
            ('Law'),
            ('LGBTQ+ Books'),
            ('Literature & Fiction'),
            ('Medical Books'),
            ('Mystery, Thriller & Suspense'),
            ('Parenting & Relationships'),
            ('Politics & Social Sciences'),
            ('Reference'),
            ('Religion & Spirituality'),
            ('Romance'),
            ('Science & Math'),
            ('Science Fiction & Fantasy'),
            ('Self-Help'),
            ('Sports & Outdoors'),
            ('Teen & Young Adult'),
            ('Test Preparation'),
            ('Travel')
end;
