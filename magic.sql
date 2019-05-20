-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 20 mai 2019 à 14:34
-- Version du serveur :  5.7.21
-- Version de PHP :  7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `magic`
--

-- --------------------------------------------------------

--
-- Structure de la table `avis`
--

DROP TABLE IF EXISTS `avis`;
CREATE TABLE IF NOT EXISTS `avis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produit_id` int(11) DEFAULT NULL,
  `rating` double NOT NULL,
  `full_name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` longtext COLLATE utf8mb4_unicode_ci,
  `created_at` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_8F91ABF0F347EFB` (`produit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=305 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `avis`
--

INSERT INTO `avis` (`id`, `produit_id`, `rating`, `full_name`, `email`, `description`, `created_at`) VALUES
(264, 121, 5, 'Sigmund Krajcik Jr.', 'ahermiston@kshlerin.biz', 'Enim doloremque qui pariatur est ut corrupti sit.', '2019-01-07 03:22:37'),
(265, 121, 3, 'Charlene Donnelly', 'keebler.vern@hotmail.com', 'Culpa quod ex odit eius error.', '2019-01-07 03:22:37'),
(266, 121, 2, 'Gunner Goldner DDS', 'giuseppe46@king.com', 'Eveniet itaque incidunt beatae.', '2019-01-07 03:22:37'),
(267, 121, 4, 'Andres Lindgren', 'parker.ed@hotmail.com', 'Laborum inventore similique rerum in nihil.', '2019-01-07 03:22:37'),
(268, 122, 3, 'Eldridge Gusikowski', 'porter.denesik@yahoo.com', 'Accusamus vel iste sit voluptatem.', '2019-01-07 03:22:37'),
(269, 122, 1, 'Oma Sawayn DDS', 'hoeger.peter@gmail.com', 'Et aliquid eos at aut.', '2019-01-07 03:22:37'),
(270, 122, 4, 'Colt Bruen', 'carlo.quigley@reynolds.com', 'Error est molestiae saepe sint.', '2019-01-07 03:22:37'),
(271, 122, 2, 'Miss Addie Prohaska', 'qjast@kessler.com', 'Nemo et itaque neque.', '2019-01-07 03:22:37'),
(272, 123, 1, 'Mrs. Fatima Donnelly', 'anibal.raynor@yahoo.com', 'Earum molestiae voluptatem corrupti facilis nisi.', '2019-01-07 03:22:37'),
(273, 123, 4, 'Bryce Hoppe', 'webster.emmerich@hermann.com', 'Ea temporibus dolorum molestiae ipsum dolores error soluta.', '2019-01-07 03:22:37'),
(274, 123, 3, 'Lindsay Kunde', 'nader.eldred@hotmail.com', 'Totam impedit consequatur facere excepturi velit et nulla.', '2019-01-07 03:22:37'),
(275, 124, 3, 'Ms. Joanie Runolfsdottir II', 'lenna67@emard.com', 'Amet at nisi culpa aut alias.', '2019-01-07 03:22:37'),
(276, 124, 3, 'Prof. Jamar Weissnat', 'erick32@hotmail.com', 'Nihil commodi harum inventore cumque voluptates vitae.', '2019-01-07 03:22:37'),
(277, 124, 1, 'Prof. Abdiel Klocko', 'porter01@rau.com', 'Quia corrupti consequuntur impedit rerum.', '2019-01-07 03:22:37'),
(278, 124, 3, 'Jessika Mayer', 'elwyn36@gmail.com', 'Deleniti sit ratione quas assumenda.', '2019-01-07 03:22:37'),
(279, 141, 4, 'Winfield Schinner', 'aberge@yahoo.com', 'Consequatur sed laudantium eum eos.', '2019-01-07 03:22:37'),
(280, 141, 2, 'Bailey Block', 'tdavis@kunze.com', 'Quia aperiam explicabo est quo quia sunt perferendis.', '2019-01-07 03:22:37'),
(281, 141, 5, 'Devonte Mueller', 'oaltenwerth@hotmail.com', 'Et dicta ullam nesciunt molestias.', '2019-01-07 03:22:37'),
(282, 142, 3, 'Sebastian Runte DDS', 'fgoyette@oberbrunner.com', 'Non corporis vel deserunt quam qui.', '2019-01-07 03:22:37'),
(283, 142, 3, 'Eric Hermiston', 'daugherty.berneice@hayes.biz', 'Repellat aspernatur accusamus molestiae voluptatem quisquam ipsum.', '2019-01-07 03:22:37'),
(284, 142, 4, 'Jaylen Ledner', 'rosemary.ondricka@yahoo.com', 'Explicabo nesciunt dicta aut dolore ipsa accusamus.', '2019-01-07 03:22:37'),
(285, 143, 5, 'Mr. Bernie Grady Sr.', 'xbrakus@gmail.com', 'Inventore ut id ut praesentium autem voluptas repellendus vel.', '2019-01-07 03:22:37'),
(286, 143, 5, 'Marian Kilback', 'uwilkinson@heidenreich.com', 'Cupiditate doloribus assumenda porro optio.', '2019-01-07 03:22:37'),
(287, 143, 3, 'Dr. Emely Bosco IV', 'salma93@marvin.net', 'Alias aliquid aut similique omnis rerum aliquam esse.', '2019-01-07 03:22:37'),
(288, 144, 1, 'Kaitlyn Jerde', 'quinton41@hotmail.com', 'Rerum odit nesciunt eum in aut et dolore.', '2019-01-07 03:22:37'),
(289, 144, 3, 'Marisa Dicki', 'lesch.cale@rice.info', 'Nisi saepe fugiat minima quo labore et.', '2019-01-07 03:22:37'),
(290, 145, 4, 'Lysanne Hills', 'theodore.ward@hoppe.net', 'Porro velit totam culpa reprehenderit dolores distinctio molestiae.', '2019-01-07 03:22:37'),
(291, 145, 5, 'Prof. Anais Borer I', 'kerluke.nelle@parker.com', 'Totam optio dolores ullam recusandae voluptatum.', '2019-01-07 03:22:37'),
(292, 146, 2, 'Lyric Littel', 'everett32@kulas.com', 'Ab consequatur soluta maxime maxime repudiandae maxime quos.', '2019-01-07 03:22:37'),
(293, 146, 2, 'Prof. Percival Gibson', 'balistreri.edwardo@gmail.com', 'Deleniti dolorem perferendis ut aut fugit exercitationem qui nemo.', '2019-01-07 03:22:37'),
(294, 146, 4, 'Norwood Funk', 'suzanne.keebler@weber.com', 'Quaerat illo deserunt quae enim voluptas corporis praesentium quis.', '2019-01-07 03:22:37'),
(295, 146, 3, 'Hosea Gaylord', 'rau.lourdes@gmail.com', 'Et illum saepe unde aspernatur ut.', '2019-01-07 03:22:37'),
(296, 147, 3, 'Ms. Polly Moen', 'vreinger@powlowski.com', 'Provident nobis quam repudiandae recusandae.', '2019-01-07 03:22:37'),
(297, 147, 1, 'Mr. Garret Mayer', 'oreilly.bryana@frami.net', 'Odio quo quam et consequatur et nisi sint.', '2019-01-07 03:22:37'),
(298, 148, 1, 'Hettie Kirlin', 'mandy.dooley@yahoo.com', 'Dolorum sunt eum occaecati praesentium.', '2019-01-07 03:22:37'),
(299, 122, 5, 'benjamin', 'benjamin51.simon@gmail.com', 'Franchement lui c\'est le meilleur', '2019-01-07 10:00:35'),
(300, 148, 4, 'Le consommateur confirmé', 'conso@conso.com', 'Pour la prendre 1 fois par semaine, c\'est plutôt un bon choix', '2019-01-07 10:14:17'),
(301, 149, 1, 'le nain', 'lenain@lenain.com', 'Bonjour je suis un nain, le poulet fait ma taille c\'est pas sympa', '2019-01-07 10:14:56'),
(303, 149, 1, 'le nain', 'lenain@lenain.com', 'Bonjour je suis un nain, le poulet fait ma taille c\'est pas sympa', '2019-01-07 10:17:28'),
(304, 150, 3, 'Johnny Veggie', 'joynnh@johnny', 'Alors là, on a fait fort, vous arrivez à nous vendre tous ce que vous voulez quand-même !', '2019-01-07 10:18:15');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` longtext COLLATE utf8mb4_unicode_ci,
  `image` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `libelle`, `description`, `image`) VALUES
(55, 'Burgers au cochon', 'Burgers au cochon', 'https://ws.mcdonalds.fr/media/a5/9c/13/a59c13b37a12efef89a194795944b31fba962b3d'),
(56, 'Burgers au poulet', 'Burgers avec du poulet dedans', 'https://d1nqx6es26drid.cloudfront.net/app/uploads/2015/04/04043910/product-mcchicken.png'),
(57, 'Burgers au poisson', 'Burgers avec du poisson dedans', 'https://ws.mcdonalds.fr/media/cf/02/31/cf02315b7c483cfc7db155c8f4ab60f92122f80c'),
(58, 'Autre', 'Le reste', 'http://www.lebonpote.net/wp-content/uploads/2017/08/LA-BO%C3%8ETE-DE-8-CHICKEN-STICKS.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `full_name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `city` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zip_code` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telephone` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=149 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `full_name`, `email`, `address`, `city`, `zip_code`, `telephone`, `created_at`) VALUES
(144, 'aserejeheeeheee', 'lasketchup@gmail.com', 'oufskjkdfdf', 'labas', '66502', '07770806', '2019-01-08 22:47:53'),
(145, 'bullerengue', 'lescastizos@gmail.com', 'sldllsdls', 'llfdnfdj', '66509', '088800807', '2019-01-08 22:51:20'),
(146, 'Simon Benjamin', 'sasukesimon@cegetel.net', '2,rue des eucalyptus', 'Le Soler', '66270', '0777373416', '2019-01-08 22:56:11'),
(147, 'Noémie Sanchez', 'benjamin51.simon@gmail.com', '3,rue mcdo', 'Claira', '66001', '0777373416', '2019-01-08 23:34:45'),
(148, 'toto toto', 'toto@gmail.com', '8,rue du toto', 'totoville', '555000', '06666666', '2019-01-09 09:25:28');

-- --------------------------------------------------------

--
-- Structure de la table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lastname` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `username` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `city` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `zipcode` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `customer`
--

INSERT INTO `customer` (`id`, `name`, `lastname`, `username`, `email`, `password`, `address`, `city`, `zipcode`) VALUES
(1, 'tristan', 'simon', 'titi66270', 'tristan@symfony.com', '$2y$13$oK5M51N/UAlgISdgduvo0.T8qCI0149jlFaVGE0X84Tdd57pcMpo6', '2,rue des eucalyptus', 'Le Soler', '66270');

-- --------------------------------------------------------

--
-- Structure de la table `ligne_commande`
--

DROP TABLE IF EXISTS `ligne_commande`;
CREATE TABLE IF NOT EXISTS `ligne_commande` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produit_id` int(11) DEFAULT NULL,
  `commande_id` int(11) DEFAULT NULL,
  `quantite` int(11) NOT NULL,
  `prix` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IDX_3170B74BF347EFB` (`produit_id`),
  KEY `IDX_3170B74B82EA2E54` (`commande_id`)
) ENGINE=InnoDB AUTO_INCREMENT=296 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `ligne_commande`
--

INSERT INTO `ligne_commande` (`id`, `produit_id`, `commande_id`, `quantite`, `prix`) VALUES
(245, 121, 122, 1, 178),
(246, 121, 122, 1, 178),
(247, 122, 123, 3, 811),
(248, 123, 124, 2, 122),
(249, 124, 125, 1, 213),
(250, 124, 125, 3, 213),
(251, 125, 126, 3, 447),
(252, 125, 126, 1, 447),
(253, 125, 126, 2, 447),
(254, 125, 126, 1, 447),
(255, 126, 127, 1, 782),
(256, 127, 128, 3, 683),
(257, 128, 129, 2, 70),
(258, 129, 130, 3, 496),
(259, 129, 130, 3, 496),
(260, 129, 130, 3, 496),
(261, 130, 131, 2, 832),
(262, 130, 131, 2, 832),
(263, 130, 131, 2, 832),
(264, 131, 132, 3, 119),
(265, 131, 132, 3, 119),
(266, 132, 133, 2, 766),
(267, 132, 133, 1, 766),
(268, 132, 133, 3, 766),
(269, 133, 134, 3, 366),
(270, 133, 134, 2, 366),
(271, 134, 135, 1, 153),
(272, 135, 136, 1, 650),
(273, 135, 136, 2, 650),
(274, 135, 136, 3, 650),
(275, 135, 136, 1, 650),
(276, 136, 137, 2, 624),
(277, 136, 137, 2, 624),
(278, 137, 138, 2, 115),
(279, 137, 138, 3, 115),
(280, 138, 139, 1, 479),
(281, 138, 139, 3, 479),
(282, 138, 139, 3, 479),
(283, 138, 139, 3, 479),
(284, 139, 140, 2, 940),
(285, 139, 140, 3, 940),
(286, 140, 141, 1, 464),
(287, 140, 141, 2, 464),
(288, 121, 142, 1, 8.7),
(289, 122, 143, 3, 8.7),
(290, 149, 144, 1, 8.9),
(291, 146, 145, 7, 2),
(292, 143, 146, 1, 7.9),
(293, 124, 147, 1, 8.7),
(294, 124, 148, 1, 8.7),
(295, 148, 148, 1, 12.9);

-- --------------------------------------------------------

--
-- Structure de la table `migration_versions`
--

DROP TABLE IF EXISTS `migration_versions`;
CREATE TABLE IF NOT EXISTS `migration_versions` (
  `version` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`version`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `migration_versions`
--

INSERT INTO `migration_versions` (`version`) VALUES
('20181223133835'),
('20181224110529'),
('20181224110911'),
('20181224152520'),
('20181225125345'),
('20181225133043');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description_court` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description_long` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `image_principale` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `image_secondaire1` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `image_secondaire2` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prix` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=151 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`id`, `libelle`, `description_court`, `description_long`, `image_principale`, `image_secondaire1`, `image_secondaire2`, `prix`) VALUES
(121, 'The biggest one', 'Le burger le plus connu de MacDo !', 'Ses deux steaks hachés, son cheddar fondu, ses oignons, ses cornichons, son lit de salade et sa sauce inimitable, font du Biggest One un burger culte et indémodable.', 'https://www.mcdo-strasbourg.fr/sites/default/files/big_mac_site_.png', 'https://i.ytimg.com/vi/NTz62GtxK6A/maxresdefault.jpg', 'http://s1.lemde.fr/image/2008/02/18/2000x1494/1012680_6_7cdc_les-mangeurs-de-competition-sont-regroupes-sous_3bcf76e5119a994de2d21e6b12d2e7fe.jpg', 9),
(122, 'Queen Cheese', 'Cheeseburger avec une plus grosse viande', 'Deux tranches de cheddar fondues accompagnent son steak haché pur boeuf. Des cornichons, de l\'oignon, un peu de moutard et de ketchup et tout le monde dit cheese !', 'https://ws.mcdonalds.fr/media/b1/b4/0a/b1b40a6ac687045360898c4bcffdf9601b951079', 'https://m.mcdonalds.be/_webdata/produits/chesse_small_0.png', 'http://www.slate.fr/sites/default/files/styles/1060x523/public/quarter_pounder.jpg', 9),
(123, 'Queen cheese BAKON', 'Sa majesté le Bacon', 'Avec son bacon croustillant, son steak haché et son pain aux graines de sésame, il vous offre une recette savoureuse et gourmande', 'https://ws.mcdonalds.fr/media/ae/33/6b/ae336b46d7613f48c8953d3b7ee5bb964ab0d233', 'http://www.fastandfood.fr/wp-content/uploads/2007/05/royalbacon_mcdonalds.jpg', 'http://www.goldenmoustache.com/wp-content/uploads/2016/08/131008181515_mac-do-bourges-restauraion-rapide-royal-cheese-mcdonald-s.png', 9),
(124, 'Queen Deluxe', 'Le luxe de la sauce à l\'ancienne', 'Craquez pour un savoureux steak haché avec du cheddar fondu, de la salade croquante et des oignons frais, le tout accompagné d\'une délicieuse sauce à la moutarde à l\'ancienne qui lui donne son goût si original.', 'https://ws.mcdonalds.fr/media/8d/19/f3/8d19f39fb8ac5f87bdafa91e9824d0df505ad407', 'https://i.ytimg.com/vi/EOrs04LI2Y8/maxresdefault.jpg', 'https://www.mcdonalds.fr/image/layout_icon?img_id=305531', 9),
(141, 'The farmer', 'L\'incontournable sandwich au poulet croustillant', 'Notre spécialité panée au poulet, sa salade croquante et sa sauce légèrement citronnée font du Farmer un succès incontesté et surtout incontestable depuis 1980.', 'https://i.ytimg.com/vi/bbUcq5fWgJc/maxresdefault.jpg', 'https://d1nqx6es26drid.cloudfront.net/app/uploads/2015/04/04043910/product-mcchicken.png', 'https://www.mcdonaldsarabia.com/content/dam/Arabia/Products/Hero/Mc-Chicken.png', 9),
(142, 'Wrap Farmer', 'Une recette gourmande pour les petites faims', 'Une galette de blé garnie de poulet croustillant, du cheddar fondu et des oignons frits, le tout accompagné d\'une sauce onctueuse.', 'http://commeaufastfood.fr/wp-content/uploads/2014/10/ptit-wrap-ranch.jpg', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJleVWOuPr0e6OobvLNBl9KKG8Oui82GFITimiyRa45iiHfcYc', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmvZzkFHFretS6IFZtT-l8NovxwUOveZOG1Mu9Qy3qcwMaHMYIeQ', 2),
(143, 'Bacon Farmer', 'Où le Wrap New York', 'Venez découvrir la fraîcheur du Bacon Farmer : Une galette de blé garnie de deux généreux morceaux de poulets panés accompagnés de batavia, de rondelle de tomates, d\'oignons frits avec une délicieuse sauce légèrement citronnée.', 'https://ws.mcdonalds.fr/media/f8/8e/42/f88e42366f6645b4f00b005dd26db8aef19a4f54', 'https://www.nouveautes-conso.fr/wp-content/uploads/2017/04/mcwrap-newyork2.jpg', 'https://www.mcdonalds.fr/documents/10192/560032/AUTOPROMO_CARROUSEL_854x374_2.jpg/d41b0eba-09cb-47bf-94de-5c84a4f69211?t=1542617417109', 8),
(144, 'First Farmer', 'Le menu à bas prix qui plaira aux grands et aux petits', 'Pain spécial aux graines de sésame et de pavot, spécialité panée au poulet, cheddar fondu, oignons, cornichons, salade, ketchup, sauce Ranch.', 'https://ws.mcdonalds.fr/media/be/ce/aa/beceaac730428239d8eebfb048804554fdf719fe', 'http://www.myburger.fr/images/upload/20150303-1110_beceaac730428239d8eebfb048804554fdf719fe.jpg', 'https://ws.mcdonalds.fr/media/44/11/16/44111670abb55cbd8d133076049d1dc4764ef67d', 5),
(145, 'First Sea Burger', 'Le nouveau First Sea Burger', 'Pain spécial aux graines de sésame et de pavot, spécialité panée au poisson, cheddar fondu, oignons, salade, ketchup, sauce Ranch.', 'https://ws.mcdonalds.fr/media/44/11/16/44111670abb55cbd8d133076049d1dc4764ef67d', 'http://www.myburger.fr/images/chroniques/grande_1647_mc_donalds_FR_poisson_ranch_03.jpg', 'https://m.mcdonalds.be/_webdata/produits/fish_small_0.png', 5),
(146, 'Little Sea Burger', 'Le petit frère du Mega Sea Burger', 'Caché au fond du menu enfant, le Little Sea Burger gagne à être connu : un pain lisse autour d\'un poisson pané délicieusement croustillant et un peu de ketchup. Idéal pour s\'initier au poisson !', 'https://m.mcdonalds.be/_webdata/produits/11_fish_3.png', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpRj3gmPRKUnTiwVGZoPvHnggEHP1EBgVQy9sBe4JPlXhW_SBT', 'https://ws.mcdonalds.fr/media/b5/e1/04/b5e104a23e9b16d2b941ba5f86c16f6ba3b0076e', 2),
(147, 'Mega Sea burger', 'Le grand frère du mcfish', 'Le grand frère du Sea Burger, un incontournable, avec sa sauce filet choisissez 1 où 2 poissons', 'https://ws.mcdonalds.fr/media/cf/02/31/cf02315b7c483cfc7db155c8f4ab60f92122f80c', 'http://www.myburger.fr/images/chroniques/grande_1644_mc_donalds_FR_double_filet_o_fish_05.jpg', 'http://www.photos-non-contractuelles.fr/media/cache/photo_voir/uploads/2011/01/15/filet_o_fish_mcdonald_avant.jpg', 9),
(148, 'La pot\' Box', 'À partager sans plus attendre !', 'Craquez pour ces Nuggets croustillants, à savourer avec 3 sauces au choix, en famille ou entre amis, faîtes-vous plaisir !', 'https://ws.mcdonalds.fr/media/a4/8e/54/a48e54deb4f6f6ad43028bb72bc0f124cc5737fb', 'http://www.fastandfood.fr/wp-content/uploads/2013/07/McNugget_MCDO3.jpg', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTK3BSNLT__mI36xBnFapZ_57K0NlwswLNhH_2BmaYhUXWL6kw3', 13),
(149, 'La pot\' Box Poulet Edition', 'Il y a du nouveau dans la boîte à partager !', 'Une boîte exclusivement remplie de Blanc de Poulet Frits, de généreux batônnnets au poulet croustillant, accompagnée de 3 sauces au choix.', 'https://ws.mcdonalds.fr/media/cb/b7/f0/cbb7f0d983b51c8bd722779bde9c9793a08a84f3', 'https://www.mcdo-strasbourg.fr/sites/default/files/boiteapartager.png', 'https://www.mcdo-strasbourg.fr/sites/default/files/actus/bap_detoure.png', 9),
(150, 'La pot\' Box Vegan', 'Car il en faut pour tous les goûts', 'Découvrez et partager la nouvelle pot\' Box composée de 8 galettes panées aux légumes 100% locaux accompagnée de 3 sauces au choix.', 'https://ws.mcdonalds.fr/media/b6/b3/65/b6b3659ccd68b7a2660d02f0856805035603e00e', 'http://www.leparisien.fr/images/2018/07/10/56b2d572-8364-11e8-9257-e1baa0a95a2d_1.jpg', 'https://www.mcdonalds.fr/documents/10192/540102/MCDO_RECETTE_VEGGIE_AUTOPROMO_854x374_100ko.jpg/ed5e5e49-8e63-452a-b856-97d5a01d3a6a?t=1530784264321', 13);

-- --------------------------------------------------------

--
-- Structure de la table `produit_categorie`
--

DROP TABLE IF EXISTS `produit_categorie`;
CREATE TABLE IF NOT EXISTS `produit_categorie` (
  `produit_id` int(11) NOT NULL,
  `categorie_id` int(11) NOT NULL,
  PRIMARY KEY (`produit_id`,`categorie_id`),
  KEY `IDX_CDEA88D8F347EFB` (`produit_id`),
  KEY `IDX_CDEA88D8BCF5E72D` (`categorie_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `produit_categorie`
--

INSERT INTO `produit_categorie` (`produit_id`, `categorie_id`) VALUES
(121, 55),
(122, 55),
(123, 55),
(124, 55),
(141, 56),
(142, 56),
(143, 56),
(144, 56),
(145, 57),
(146, 57),
(147, 57),
(148, 58),
(149, 58),
(150, 58);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(180) COLLATE utf8mb4_unicode_ci NOT NULL,
  `roles` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_8D93D649E7927C74` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `email`, `roles`, `password`) VALUES
(8, 'benjamin51.simon@gmail.com', 'ROLE_ADMIN', '$argon2i$v=19$m=1024,t=2,p=2$VEN6M3l2WUlVUWplMFF1Lg$d/Gs3cHZCHYTeNSWw3sO4ZSMMqgJkuXX7AzRGyeuzSo');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `produit_categorie`
--
ALTER TABLE `produit_categorie`
  ADD CONSTRAINT `FK_CDEA88D8BCF5E72D` FOREIGN KEY (`categorie_id`) REFERENCES `categorie` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_CDEA88D8F347EFB` FOREIGN KEY (`produit_id`) REFERENCES `produit` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
